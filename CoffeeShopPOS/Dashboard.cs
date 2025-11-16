    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace CoffeeShopPOS
    {
        public partial class Dashboard : Form
        {
            private string loggedInUser;
            public Dashboard(string user)
            {
                InitializeComponent();
                loggedInUser = user;
            }

            private void Dashboard_Load(object sender, EventArgs e)
            {
                lblWelcome.Text = $"Welcome, {loggedInUser}!";
            }

            private void lblWelcome_Click(object sender, EventArgs e)
            {

            }

            private void iconButton1_Click(object sender, EventArgs e)
            {
                this.Hide();
                MenuManagementt menuForm = new MenuManagementt(loggedInUser);
                menuForm.Show();
            }

            private void btnManageCustomers_Click(object sender, EventArgs e)
            {
                this.Hide();
                CustomerManagement customerForm = new CustomerManagement(loggedInUser);
                customerForm.Show();
            }

            private void btnCreateOrder_Click(object sender, EventArgs e)
            {
                this.Hide();
                OrderForm orderForm = new OrderForm(loggedInUser);
                orderForm.Show();
            }

            private void btnViewSales_Click(object sender, EventArgs e)
            {
                this.Hide();
                Getsales salesForm = new Getsales(loggedInUser);
                salesForm.Show();
            }

            private void btnLogout_Click(object sender, EventArgs e)
            {
                var confirm = MessageBox.Show("Are you sure you want to logout?",
                   "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    this.Hide();
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
            }
        }
    }
