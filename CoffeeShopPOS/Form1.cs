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
    public partial class Form1 : Form
    {
        private readonly string connectionString = DbConnectionHelper.GetConnection().ConnectionString;
        private string loggedInUser;

        public Form1()
        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string password = passwordTB.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dash = new Dashboard(loggedInUser);
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
            }
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            Registration registerForm = new Registration();
            registerForm.Show();
            this.Hide();
        }
    }
}
