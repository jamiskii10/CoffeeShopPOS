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
            private int userID;

        public Dashboard(string loggedInUser, int userID)
            {
                InitializeComponent();
            this.userID = userID;
            this.loggedInUser = loggedInUser;

        }

            private void Dashboard_Load(object sender, EventArgs e)
            {
            lblWelcome.Text = $"Welcome, {loggedInUser}!";
            lblOnDuty.Text = $"On Duty Today: {loggedInUser}";
        }

            private void lblWelcome_Click(object sender, EventArgs e)
            {

            }

            private void iconButton1_Click(object sender, EventArgs e)
            {
            MenuManagementt menuForm = new MenuManagementt(loggedInUser, userID);
            menuForm.Show();
            this.Hide();
        }

            private void btnManageCustomers_Click(object sender, EventArgs e)
            {
           
            this.Hide();
            CustomerManagement customerForm = new CustomerManagement(loggedInUser, userID);
            customerForm.Show();
        }

            private void btnCreateOrder_Click(object sender, EventArgs e)
            {
            
            this.Hide();
            OrderForm orderForm = new OrderForm(loggedInUser, userID);
            orderForm.Show();
        }

            private void btnViewSales_Click(object sender, EventArgs e)
            {
            Getsales salesForm = new Getsales(loggedInUser, userID);
            salesForm.Show();
            this.Hide();

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

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ReceiptForm r = new ReceiptForm();
            r.Show();
        }
    }
    }
