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
    public partial class Registration : Form
    {
        private readonly string connectionString = DbConnectionHelper.GetConnection().ConnectionString;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            string firstName = fnameTB.Text.Trim();
            string lastName = lnameTB.Text.Trim();
            string contact = contactTB.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("This email is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertQuery = "INSERT INTO Users (Email, Password, FirstName, LastName, Contact) VALUES (@Email, @Password, @FirstName, @LastName, @Contact)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }

        }

        private void ClearFields()
        {
            emailTB.Clear();
            passwordTB.Clear();
            fnameTB.Clear();
            lnameTB.Clear();
            contactTB.Clear();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
           Form1 login = new Form1();
              login.Show();
                this.Hide();
        }
    }
}
