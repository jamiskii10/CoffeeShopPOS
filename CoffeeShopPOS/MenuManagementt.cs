using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;        
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeShopPOS
{
    public partial class MenuManagementt : Form
    {
        private string loggedInUser;
        private int userID;
        public MenuManagementt(string loggedInUser, int userID)
        {
            InitializeComponent();
            LoadMenuItems();
            this.loggedInUser = loggedInUser;
            this.userID = userID;
            menuDGV.CellClick += menuDGV_CellClick; //Hook up an event handler for when a user clicks on a cell in the DataGridView (DGV)

            // Disable update/delete initially
            button2.Enabled = false;
            deleteBTN.Enabled = false;
        }

        private void LoadMenuItems()  // Method to fetch all menu items from the database and display them in the DataGridView
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MenuID, ItemName, Category, Price FROM MENU";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                   menuDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message);
            }
        }
        private bool ValidateInputs()    // Helper method to validate the input fields before adding or updating an item
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Item name cannot be blank.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category cannot be blank.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price.");
                return false;
            }

            return true;
        }
  
        private void menuDGV_CellClick(object sender, DataGridViewCellEventArgs e)  // Event handler for when a user clicks a cell in the menu DataGridView
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = menuDGV.Rows[e.RowIndex];

                txtName.Text = row.Cells["ItemName"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

                // Enable update/delete buttons
                button2.Enabled = true;
                deleteBTN.Enabled = true;

                // Highlight row
                menuDGV.Rows[e.RowIndex].Selected = true;
            }
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // Check if a product with the same name and category already exists in the DB
                    string checkQuery = "SELECT COUNT(*) FROM MENU WHERE ItemName = @ItemName AND Category = @Category";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ItemName", txtName.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("This product already exists in this category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop execution if a duplicate is found
                    }

                    // Logic to automatically generate the next sequential MenuID (e.g., M001, M002)
                    string getMaxIdQuery = "SELECT ISNULL(MAX(CAST(SUBSTRING(MenuID, 2, LEN(MenuID)) AS INT)), 0) + 1 FROM MENU";
                    SqlCommand getMaxIdCmd = new SqlCommand(getMaxIdQuery, conn);
                    int nextId = Convert.ToInt32(getMaxIdCmd.ExecuteScalar());
                    string newMenuID = "M" + nextId.ToString("000");

                    // SQL query to insert the new item into the MENU table
                    string query = "INSERT INTO MENU (MenuID, ItemName, Price, Category) VALUES (@MenuID, @ItemName, @Price, @Category)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MenuID", newMenuID);
                        cmd.Parameters.AddWithValue("@ItemName", txtName.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Menu item added successfully!");
                ClearFields();
                LoadMenuItems(); // Refresh the DataGridView to show the new item
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)    // Event handler for the "Update" button click
        {
            if (menuDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }
            if (!ValidateInputs()) return;
            try
            {
                string menuID = menuDGV.SelectedRows[0].Cells["MenuID"].Value.ToString();   // Get the unique MenuID of the selected row

                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    // SQL query to update the selected item's details based on its MenuID
                    string query = "UPDATE MENU SET ItemName=@ItemName, Price=@Price, Category=@Category WHERE MenuID=@MenuID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemName", txtName.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                        cmd.Parameters.AddWithValue("@MenuID", menuID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Menu item updated successfully!");
                ClearFields();
                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating item: " + ex.Message);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)  // Event handler for the "Delete" button click
        {
            if (menuDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this item?",
                 "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {   // Get the unique MenuID of the selected row
                string menuID = menuDGV.SelectedRows[0].Cells["MenuID"].Value.ToString();

                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();  // SQL query to delete the selected item based on its MenuID
                    string query = "DELETE FROM MENU WHERE MenuID=@MenuID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MenuID", menuID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Menu item deleted successfully!");
                ClearFields();
                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }

        private void ClearFields() //Method para i reset ang input fields/textboxees
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
            menuDGV.ClearSelection();

            button2.Enabled = false;
            deleteBTN.Enabled = false;
        }

        private void backBTN_Click(object sender, EventArgs e) //Mu return sa Dashboard
        {
            this.Hide();
            Dashboard dash = new Dashboard(loggedInUser, userID);
            dash.Show();
        }

        private void MenuManagementt_Load(object sender, EventArgs e)
        {

        }
    }
}
