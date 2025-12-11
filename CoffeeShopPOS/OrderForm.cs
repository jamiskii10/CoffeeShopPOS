using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CoffeeShopPOS
{
    public partial class OrderForm : Form
    {
                                              // Fields to manage the current transaction state and user info
        private string currentOrderID = null; // Stores the ID of the order being built (null until 'Create Order' is clicked)
        private decimal totalAmount = 0;      // Stores the running total price of the order
        private DataTable orderItemsTable;    // A temporary in-memory table to hold items added to the current order
        private string loggedInUser;
        private int userID;

        public OrderForm(string loggedInUser, int userID) // Constructor: Runs when the OrderForm is initialized
        {
            InitializeComponent();
            InitializeOrderItemsTable();                   // Sets up the structure for the temporary order data table
            LoadCustomers();                              // Populates the customer dropdown list
            LoadMenu();                                  // Populates the menu items grid
            this.loggedInUser = loggedInUser;           // Store user session info
            this.userID = userID;

        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Ensures the in-memory data table is ready if it somehow wasn't initialized in the constructor
            if (orderItemsTable == null)
                InitializeOrderItemsTable();
        }

        // Sets up the columns for the in-memory DataTable that displays items in the 'order cart'
        private void InitializeOrderItemsTable() 
        {
            orderItemsTable = new DataTable();
            orderItemsTable.Columns.Add("MenuID");
            orderItemsTable.Columns.Add("ItemName");
            orderItemsTable.Columns.Add("Price", typeof(decimal));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("SubTotal", typeof(decimal), "Price * Quantity");

            orderDGV.DataSource = orderItemsTable; // Bind the DataTable to the Order DataGridView
            orderDGV.AutoGenerateColumns = true;   // Automatically display all columns
            orderDGV.Refresh();

        }

        // Method to fetch customer list from the database and populate the ComboBox
        private void LoadCustomers() 
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string query = "SELECT CustID, FullName FROM Customer";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Configure the ComboBox to show FullName but use CustID internally as the value
                comboCustomer.DisplayMember = "FullName";
                comboCustomer.ValueMember = "CustID";
                comboCustomer.DataSource = dt;
            }
        }

        // Method to fetch menu items from the database and populate the menu DataGridView
        private void LoadMenu()
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string query = "SELECT MenuID, ItemName, Category, Price FROM MENU";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                menuDGV.DataSource = dt;
            }
        }

        // Event handler for the "Create Order" button click
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Validation: Must select a customer first
            if (comboCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }
            // If an order is already active, clear the previous one first
            // (Current logic just creates a new header record, assumes old one is cleared via btnClear_Click before this)

            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                // Call a stored procedure in the database to create a new Order header record
                SqlCommand cmd = new SqlCommand("sp_CreateOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustID", comboCustomer.SelectedValue.ToString());

                // The stored procedure is expected to return the new OrderID
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    currentOrderID = reader["NewOrderID"].ToString();
                    MessageBox.Show($"Order created successfully!\nOrder ID: {currentOrderID}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create order.");
                }

            }

        }

        // Event handler for the "Add to Order" button click (adds a menu item to the current local cart)
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            // Validation 1: An order must be initiated first
            if (string.IsNullOrEmpty(currentOrderID))
            {
                MessageBox.Show("Please create an order first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation 2: Must select an item from the menu grid
            if (menuDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item from the menu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation 3: Must enter a valid, positive quantity
            if (!int.TryParse(quantityTB.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get details of the selected menu item
            DataGridViewRow selectedRow = menuDGV.SelectedRows[0];
            string menuID = selectedRow.Cells["MenuID"].Value.ToString();
            string itemName = selectedRow.Cells["ItemName"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
           

            DataRow existingRow = orderItemsTable.AsEnumerable()
        .FirstOrDefault(r => r.Field<string>("MenuID") == menuID);

            // If it exists, just update the quantity in the local table
            if (existingRow != null)
            {
                existingRow["Quantity"] = Convert.ToInt32(existingRow["Quantity"]) + quantity;
            }
            else
            {
                // If it's new, add a fresh row to the local table
                orderItemsTable.Rows.Add(menuID, itemName, price, quantity);
            }
            // Recalculate the total amount using the calculated 'SubTotal' column in the DataTable
            totalAmount = orderItemsTable.AsEnumerable().Sum(r => r.Field<decimal>("SubTotal"));
            lblTotal.Text = $"₱ {totalAmount:N2}";

            quantityTB.Clear(); // Clear the quantity input box for the next item
        }


        // Event handler for the "Save Order" button click (Persists local cart data to the DB)
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            // Validation 1: Ensure there are items in the cart
            if (orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validation 2: Ensure an OrderID was successfully generated
            if (string.IsNullOrEmpty(currentOrderID))
            {
                MessageBox.Show("Order ID is missing. Please click 'Create Order' first.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // Iterate through every item in the local order table and save it as an OrderDetail record
                    foreach (DataRow row in orderItemsTable.Rows)
                    {
                        // After saving all details, update the main 'Orders' table with the final calculated TotalAmount
                        using (SqlCommand cmd = new SqlCommand("sp_AddOrderDetail", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                            cmd.Parameters.AddWithValue("@MenuID", row["MenuID"].ToString());
                            cmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Update total in Orders table
                    SqlCommand updateTotal = new SqlCommand(
                        "UPDATE Orders SET TotalAmount = @Total WHERE OrderID = @OrderID", conn);
                    updateTotal.Parameters.AddWithValue("@Total", totalAmount);
                    updateTotal.Parameters.AddWithValue("@OrderID", currentOrderID);
                    updateTotal.ExecuteNonQuery();
                }

                MessageBox.Show("Order saved successfully!");
                // Reset the form for a new order
                orderItemsTable.Clear();
                lblTotal.Text = "₱ 0.00";
                totalAmount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message);
            }
        }

        // Helper method to clear all form fields and reset the transaction state
        private void ClearOrderForm()
        {
            // Clear order items table
            orderItemsTable.Clear(); 
            orderDGV.DataSource = orderItemsTable;
            orderDGV.Refresh();

            // Clear UI fields
            comboCustomer.SelectedIndex = -1; // Deselect customer
            quantityTB.Clear();
            lblTotal.Text = "₱ 0.00";

            // Reset order ID and total
            currentOrderID = null;
            totalAmount = 0;
            
        }

        // Event handler for the "Clear/New Order" button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrderForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Hide();
              Dashboard dashboardForm = new Dashboard(loggedInUser, userID);
            dashboardForm.Show();

        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }
    }
}
