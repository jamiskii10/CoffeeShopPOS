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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOnDuty = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(23, 98);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(954, 537);
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
            this.btnViewSales.Location = new System.Drawing.Point(87, 470);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(192, 52);
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
            this.btnCreateOrder.Location = new System.Drawing.Point(87, 386);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(192, 58);
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
            this.btnManageCustomers.Location = new System.Drawing.Point(87, 304);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(192, 52);
            this.btnManageCustomers.TabIndex = 2;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.AutoSize = true;
            this.btnManageMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageMenu.IconColor = System.Drawing.Color.Black;
            this.btnManageMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageMenu.Location = new System.Drawing.Point(87, 221);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(192, 54);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShopPOS.Properties.Resources.Kope;
            this.pictureBox1.Location = new System.Drawing.Point(399, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblOnDuty
            // 
            this.lblOnDuty.AutoSize = true;
            this.lblOnDuty.Depth = 0;
            this.lblOnDuty.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOnDuty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOnDuty.Location = new System.Drawing.Point(28, 61);
            this.lblOnDuty.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOnDuty.Name = "lblOnDuty";
            this.lblOnDuty.Size = new System.Drawing.Size(0, 24);
            this.lblOnDuty.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME TO KAPEY";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(87, 548);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(192, 56);
            this.btnReceipt.TabIndex = 9;
            this.btnReceipt.Text = "Receipts";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1118, 616);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOnDuty);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblOnDuty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceipt;
    }
}