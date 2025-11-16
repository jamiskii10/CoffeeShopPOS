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

        private readonly string connectionString =
           @"Data Source=LAPTOP-NI3QOG5B\SQLEXPRESS;Initial Catalog=CoffeeShop;Integrated Security=True;TrustServerCertificate=True";
        public Getsales(string user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void Getsales_Load(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetSalesSummary", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Table 1 = Daily Sales
                    dgvSales.DataSource = ds.Tables[0];

                    // Table 2 = Monthly Total
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        decimal monthlyTotal = Convert.ToDecimal(ds.Tables[1].Rows[0]["MonthlyTotal"]);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard("Admin");
            dash.Show();
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = $"Welcome, {loggedInUser}";
        }
    }
}
