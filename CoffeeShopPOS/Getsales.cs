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
    public partial class Getsales : Form
    {
        private string loggedInUser;
        private int userID;

        // Constructor: Runs when the Getsales form is initialized
        public Getsales(string loggedInUser, int userID)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.userID = userID;
        }

        // Event handler for when the Form window loads
        private void Getsales_Load(object sender, EventArgs e)
        {
            LoadSalesData();           // Load default/initial sales data (e.g., current month/day summary)             
            LoadYearList();             // Populate the year selection dropdown
            LoadMonthList();            // Populate the month selection dropdown
            materialLabel1.Text = $"Welcome, {loggedInUser}";
        }


        // Populates the year combo box by querying distinct years available in the Orders table
        private void LoadYearList()
        {
            try
            {
                // Use DbConnectionHelper to get a centralized connection string
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT DISTINCT YEAR(OrderDate) AS Yr FROM Orders ORDER BY Yr DESC", conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbYear.Items.Clear();  // Clear existing items
                    while (reader.Read())
                    {
                        cmbYear.Items.Add(reader["Yr"].ToString()); // Add years to the dropdown
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading year list: " + ex.Message);
            }
        }

        // Populates the month combo box with static month names
        private void LoadMonthList()
        {
            cmbMonth.Items.Clear();
            cmbMonth.Items.AddRange(new string[]
            {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
            });
        }


        // Loads initial/default sales data (likely today's or current month's sales) using a stored procedure
        private void LoadSalesData()
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_GetSalesSummary", conn)) // Indicate that we are calling a stored procedure
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet(); 
                    adapter.Fill(ds); // Fill the DataSet, which can contain multiple tables

                    // Table 1 = Daily Sales
                    dgvSales.DataSource = ds.Tables[0];

                    // Table 2 = Monthly Total
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        object mt = ds.Tables[1].Rows[0]["MonthlyTotal"];
                        // Handle potential DBNull values and format the total as currency
                        decimal monthlyTotal = mt == DBNull.Value ? 0 : Convert.ToDecimal(mt);

                        lblMonthlyTotal.Text = $"Monthly Total: ₱{monthlyTotal:N2}";
                    }
                    else
                    {
                        lblMonthlyTotal.Text = "Monthly Total: ₱0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message);
            }
        }

        // Loads sales data filtered by the selected month and year using a different stored procedure
        private void LoadFilteredSales(int month, int year)
        {
            try
            {
                using (SqlConnection conn = DbConnectionHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_GetSalesByMonthYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Use stored procedure
                      // Pass the selected month and year as parameters
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds); // Fill DataSet with results (multiple tables)

                    // Table 0 = Daily sales for selected month/year
                    dgvSales.DataSource = ds.Tables[0];

                    // ---------- MONTHLY TOTAL ----------
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        object monthlyObj = ds.Tables[1].Rows[0]["MonthlyTotal"];

                        if (monthlyObj == DBNull.Value)
                        {
                            lblMonthlyTotal.Text = "Monthly Total: ₱0.00";
                            // Inform user if no sales were found for the criteria
                            MessageBox.Show("No sales found for the selected month.", "No Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            decimal monthlyTotal = Convert.ToDecimal(monthlyObj);
                            lblMonthlyTotal.Text = $"Monthly Total: ₱{monthlyTotal:N2}";
                        }
                    }
                    else
                    {
                        lblMonthlyTotal.Text = "Monthly Total: ₱0.00";
                    }

                    // ---------- YEAR TOTAL ----------
                    if (ds.Tables.Count > 2 && ds.Tables[2].Rows.Count > 0)
                    {
                        object yearObj = ds.Tables[2].Rows[0]["YearTotal"];

                        if (yearObj == DBNull.Value)
                        {
                            lblYearTotal.Text = "Year Total: ₱0.00";
                            MessageBox.Show("No sales found for the selected year.", "No Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            decimal yearTotal = Convert.ToDecimal(yearObj);
                            lblYearTotal.Text = $"Year Total: ₱{yearTotal:N2}";
                        }
                    }
                    else
                    {
                        lblYearTotal.Text = "Year Total: ₱0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering sales: " + ex.Message);
            }
        }

        // Event handler for the "Refresh" button click (resets view to default/initial data)
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        // Event handler for the "Back" button click (navigates back to the Dashboard)
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(loggedInUser, userID);
            dash.Show();
            this.Close();
        }

        // A click handler for the welcome label itself (currently just re-sets the text)
        private void materialLabel1_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = $"Welcome, {loggedInUser}";
        }

        // Event handler for the "Filter" button click
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Validation: Ensure both month and year are selected
            if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both Month and Year.");
                return;
            }

            // Month index is 0-based in C# ComboBox, but SQL often uses 1-based months (January = 1)
            int month = cmbMonth.SelectedIndex + 1; // January = 1
            int year = Convert.ToInt32(cmbYear.SelectedItem);

            LoadFilteredSales(month, year); // Call the filtering method
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
