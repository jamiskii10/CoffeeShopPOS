using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    public partial class CustomerManagement : Form
    {

         // Fields to store info about sa current user session (e.g., who is logged in)
        private string loggedInUser; // Store the logged-in user details passed from the previous form
        private int userID;


        public CustomerManagement(string loggedInUser, int userID)
        {
            InitializeComponent();
            LoadCustomers(); // Initial call to populate the customer list when the form opens
            this.loggedInUser = loggedInUser;
            this.userID = userID;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadCustomers()   // Method to fetch all customer items from the database and display them in the DataGridView
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // SQL query to select relevant columns from the Customer table
                    string query = "SELECT CustID, FullName, ContactNo FROM Customer";
                    // DataAdapter is used to fill a DataTable with the results of the query

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    customerDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void ClearFields()  // method para ma clear ang input text boxes sa form
        {
            custIDTB.Clear();
            nameTB.Clear();
            contactTB.Clear();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            // Get user inputs from text boxes and trim whitespace
            string id = custIDTB.Text.Trim();
            string name = nameTB.Text.Trim();
            string contact = contactTB.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please fill in required fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // SQL query to insert a new customer record
                    string query = "INSERT INTO Customer (CustID, FullName, ContactNo) VALUES (@id, @name, @contact)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.ExecuteNonQuery(); // Execute the insert command
                    }
                }
                MessageBox.Show("Customer added successfully!");
                LoadCustomers(); // Refresh the DataGridView
                ClearFields(); // Clear input boxes
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected before attempting an update
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }
            // Get updated values from text boxes
            string id = custIDTB.Text.Trim();
            string name = nameTB.Text.Trim();
            string contact = contactTB.Text.Trim();

            // Input validation: ensure required fields (ID and Name) are not empty
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please fill in required fields (Customer ID and Name).");
                return; // Stop execution if validation fails
            }

            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // SQL query to update the customer's name and contact number based on their CustID
                    string query = "UPDATE Customer SET FullName=@name, ContactNo=@contact WHERE CustID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Parameters ensure the correct row is updated
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer updated successfully!");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected before attempting deletion
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }
            // Get the ID of the customer to be deleted
            string id = custIDTB.Text.Trim();

            // Show a confirmation dialog box to prevent accidental deletions
            var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return; // Stop if the user clicks 'No'

            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // SQL query to delete the customer record based on their CustID
                    string query = "DELETE FROM Customer WHERE CustID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer deleted successfully!");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}");
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(loggedInUser, userID); 
            dashboard.Show();
        }

        // Event handler that runs automatically whenever the selection in the DataGridView changes
        private void customerDGV_SelectionChanged(object sender, EventArgs e)  
        {
            // If at least one row is selected
            if (customerDGV.SelectedRows.Count > 0)
            {
                // Get the first selected row object
                var row = customerDGV.SelectedRows[0];
                // Populate the text boxes with the data from the selected row
                custIDTB.Text = row.Cells["CustID"].Value?.ToString();
                nameTB.Text = row.Cells["FullName"].Value?.ToString();
                contactTB.Text = row.Cells["ContactNo"].Value?.ToString();
            }
        }
    }
    
}
