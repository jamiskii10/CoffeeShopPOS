using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CoffeeShopPOS
{
    public partial class ReceiptForm : Form
    {
        private string loggedInUser;
        private int userID;


        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            LoadOrderList();                              // Load the list of all historical orders
            ClearReceiptDisplay();                          // Clear the receipt details panel initially
            dgvOrderList.AutoGenerateColumns = true;       // Ensure columns are generated for the list grid
            dgvOrderItems.AutoGenerateColumns = true;   // Ensure columns are generated for the items grid
        }

        // Helper method to reset the right-hand receipt display panel
        private void ClearReceiptDisplay()
        {
            lblCustomerName.Text = "";
            lblUserName.Text = "";
            lblOrderDate.Text = "";
            lblTotalAmount.Text = "";
            dgvOrderItems.DataSource = null; // Clear the items grid data
        }


        // Method to fetch the list of all orders from the database and populate the left DataGridView (dgvOrderList)
        private void LoadOrderList()
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_GetAllOrders", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOrderList.DataSource = dt;

                    // optional UI tuning
                    dgvOrderList.ReadOnly = true;
                    dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvOrderList.AllowUserToAddRows = false;
                    dgvOrderList.AllowUserToDeleteRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to fetch specific details for a selected OrderID and display them
        private void LoadReceipt(string orderID)
        {
            try
            {
                ClearReceiptDisplay();

                if (string.IsNullOrEmpty(orderID))
                {
                    MessageBox.Show("Invalid or missing Order ID. Cannot load receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_GetOrderReceipt", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // This must be SqlDbType.NVarChar to accept "OR..." strings.
                    // Assuming 50 is a sufficient length for the OrderID string.
                    cmd.Parameters.Add("@OrderID", SqlDbType.NVarChar, 50).Value = orderID;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    // TABLE 0 =  Order Header Information (Customer Name, Date, Total)
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow hdr = ds.Tables[0].Rows[0];

                        lblCustomerName.Text = "Name: " +(hdr["CustomerName"]?.ToString() ?? "");
                        lblUserName.Text = "User In Charge: " +(hdr["UserInCharge"]?.ToString() ?? "");

                        // Date handling / Safely parse and format the Order Date
                        if (DateTime.TryParse(hdr["OrderDate"]?.ToString(), out DateTime dt))
                            lblOrderDate.Text = dt.ToString("yyyy-MM-dd HH:mm");
                        else
                            lblOrderDate.Text = hdr["OrderDate"]?.ToString() ?? "N/A";

                        // Total Amount handling / Safely parse and format the Total Amount as currency
                        if (decimal.TryParse(hdr["TotalAmount"]?.ToString(), out decimal tot))
                            lblTotalAmount.Text = "₱ " + tot.ToString("N2");
                        else
                            lblTotalAmount.Text = hdr["TotalAmount"]?.ToString() ?? "N/A";
                    }
                    else
                    {
                        // This is where "No header found" comes from. The ID exists in the list, 
                        // but the SP returned nothing (e.g., ID was deleted or mismatched in DB).
                        MessageBox.Show($"No header found for OrderID = {orderID}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // TABLE 1 = items
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        dgvOrderItems.DataSource = ds.Tables[1];

                        // Formatting checks
                        if (dgvOrderItems.Columns.Contains("Price"))
                            dgvOrderItems.Columns["Price"].DefaultCellStyle.Format = "N2";
                        if (dgvOrderItems.Columns.Contains("SubTotal"))
                            dgvOrderItems.Columns["SubTotal"].DefaultCellStyle.Format = "N2";

                        dgvOrderItems.ReadOnly = true;
                        dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvOrderItems.AllowUserToAddRows = false;
                    }
                    else
                    {
                        dgvOrderItems.DataSource = null;
                        // Items grid will remain empty if no items found
                    }
                }
            }
            catch (Exception ex)
            {
                // General error catching for database issues
                MessageBox.Show("Error loading receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Event handler for when a user clicks a row in the Order List grid
        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // Ignore clicks on the header row

            // Safely get the value from the selected cell
            object orderIDValue = dgvOrderList.Rows[e.RowIndex].Cells["OrderID"].Value;

            if (orderIDValue == null || orderIDValue == DBNull.Value)
            {
                MessageBox.Show("Selected order is missing an Order ID.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pass the full string (e.g., "OR1035") to LoadReceipt
            string orderID = orderIDValue.ToString();

            LoadReceipt(orderID);
        }

        private void dgvOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrderList();
            ClearReceiptDisplay();
            MessageBox.Show("Order list refreshed!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(loggedInUser, userID);
            dashboard.Show();
        }
    }
}
