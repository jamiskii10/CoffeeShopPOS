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
    public partial class CustomerManagement : Form
    {


        private string loggedInUser;


        public CustomerManagement(string user)
        {
            InitializeComponent();
            LoadCustomers();
            loggedInUser = user;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CustID, FullName, ContactNo FROM Customer";
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

        private void ClearFields()
        {
            custIDTB.Clear();
            nameTB.Clear();
            contactTB.Clear();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
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
                    string query = "INSERT INTO Customer (CustID, FullName, ContactNo) VALUES (@id, @name, @contact)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer added successfully!");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            string id = custIDTB.Text.Trim();
            string name = nameTB.Text.Trim();
            string contact = contactTB.Text.Trim();

            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Customer SET FullName=@name, ContactNo=@contact WHERE CustID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            string id = custIDTB.Text.Trim();

            var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
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
            Dashboard dashboard = new Dashboard(loggedInUser); 
            dashboard.Show();
        }

        private void customerDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (customerDGV.SelectedRows.Count > 0)
            {
                var row = customerDGV.SelectedRows[0];
                custIDTB.Text = row.Cells["CustID"].Value?.ToString();
                nameTB.Text = row.Cells["FullName"].Value?.ToString();
                contactTB.Text = row.Cells["ContactNo"].Value?.ToString();
            }
        }
    }
    
}
