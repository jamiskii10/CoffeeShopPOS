namespace CoffeeShopPOS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnViewSales = new FontAwesome.Sharp.IconButton();
            this.btnCreateOrder = new FontAwesome.Sharp.IconButton();
            this.btnManageCustomers = new FontAwesome.Sharp.IconButton();
            this.btnManageMenu = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(229, 53);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(265, 54);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(970, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 47);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewSales.IconColor = System.Drawing.Color.Black;
            this.btnViewSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewSales.Location = new System.Drawing.Point(32, 444);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(253, 60);
            this.btnViewSales.TabIndex = 4;
            this.btnViewSales.Text = "View Daily Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreateOrder.IconColor = System.Drawing.Color.Black;
            this.btnCreateOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateOrder.Location = new System.Drawing.Point(27, 353);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(258, 63);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageCustomers.IconColor = System.Drawing.Color.Black;
            this.btnManageCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageCustomers.Location = new System.Drawing.Point(23, 272);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(262, 63);
            this.btnManageCustomers.TabIndex = 2;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageMenu.IconColor = System.Drawing.Color.Black;
            this.btnManageMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageMenu.Location = new System.Drawing.Point(23, 188);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(262, 69);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 570);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private FontAwesome.Sharp.IconButton btnManageMenu;
        private FontAwesome.Sharp.IconButton btnManageCustomers;
        private FontAwesome.Sharp.IconButton btnCreateOrder;
        private FontAwesome.Sharp.IconButton btnViewSales;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}