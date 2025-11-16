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
using System.Xml.Linq;

namespace CoffeeShopPOS
{
    public partial class MenuManagementt : Form
    {
        private string loggedInUser;
        public MenuManagementt(string user  )
        {
            InitializeComponent();
            LoadMenuItems();
            loggedInUser = user;
        }

        private void LoadMenuItems()
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
        private void clearBTN_Click(object sender, EventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
                    string getMaxIdQuery = "SELECT ISNULL(MAX(CAST(SUBSTRING(MenuID, 2, LEN(MenuID)) AS INT)), 0) + 1 FROM MENU";
                    SqlCommand getMaxIdCmd = new SqlCommand(getMaxIdQuery, conn);
                    int nextId = Convert.ToInt32(getMaxIdCmd.ExecuteScalar());
                    string newMenuID = "M" + nextId.ToString("000");

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
                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            try
            {
                string menuID = menuDGV.SelectedRows[0].Cells["MenuID"].Value.ToString();

                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
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

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (menuDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                string menuID = menuDGV.SelectedRows[0].Cells["MenuID"].Value.ToString();

                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                {
                    conn.Open();
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

        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard(loggedInUser);
            dash.Show();
        }

        private void MenuManagementt_Load(object sender, EventArgs e)
        {

        }
    }
}
