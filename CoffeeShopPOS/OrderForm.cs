using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShopPOS
{
    public partial class OrderForm : Form
    {
        private string currentOrderID = null;
        private decimal totalAmount = 0;
        private DataTable orderItemsTable;
        private string loggedInUser;
        public OrderForm(string user)
        {
            InitializeComponent();
            InitializeOrderItemsTable();
            LoadCustomers();
            LoadMenu();
            loggedInUser = user;

        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            if (orderItemsTable == null)
                InitializeOrderItemsTable();
        }
        private void InitializeOrderItemsTable()
        {
            orderItemsTable = new DataTable();
            orderItemsTable.Columns.Add("MenuID");
            orderItemsTable.Columns.Add("ItemName");
            orderItemsTable.Columns.Add("Price", typeof(decimal));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("SubTotal", typeof(decimal), "Price * Quantity");

            orderDGV.DataSource = orderItemsTable;
            orderDGV.AutoGenerateColumns = true;
            orderDGV.Refresh();

        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string query = "SELECT CustID, FullName FROM Customer";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboCustomer.DisplayMember = "FullName";
                comboCustomer.ValueMember = "CustID";
                comboCustomer.DataSource = dt;
            }
        }

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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }


            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CreateOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustID", comboCustomer.SelectedValue.ToString());
                
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

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOrderID))
            {
                MessageBox.Show("Please create an order first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (menuDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item from the menu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantityTB.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = menuDGV.SelectedRows[0];
            string menuID = selectedRow.Cells["MenuID"].Value.ToString();
            string itemName = selectedRow.Cells["ItemName"].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
           

            DataRow existingRow = orderItemsTable.AsEnumerable()
        .FirstOrDefault(r => r.Field<string>("MenuID") == menuID);


            if (existingRow != null)
            {
                existingRow["Quantity"] = Convert.ToInt32(existingRow["Quantity"]) + quantity;
            }
            else
            {
                orderItemsTable.Rows.Add(menuID, itemName, price, quantity);
            }
            totalAmount = orderItemsTable.AsEnumerable().Sum(r => r.Field<decimal>("SubTotal"));
            lblTotal.Text = $"₱ {totalAmount:N2}";

            quantityTB.Clear();
        }


        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

                    foreach (DataRow row in orderItemsTable.Rows)
                    {
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
                orderItemsTable.Clear();
                lblTotal.Text = "₱ 0.00";
                totalAmount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message);
            }
        }
            
        private void ClearOrderForm()
        {
            comboCustomer.SelectedIndex = -1;
            quantityTB.Clear();
            lblTotal.Text = "₱ 0.00";
            currentOrderID = null;
            totalAmount = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrderForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Hide();
              Dashboard dashboardForm = new Dashboard("loggedInUser");
            dashboardForm.Show();

        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }
    }
}
