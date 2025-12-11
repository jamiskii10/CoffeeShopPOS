namespace CoffeeShopPOS
{
    partial class Getsales
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblMonthlyTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblYearTotal = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(191, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "WELCOME";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(291, 140);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(650, 472);
            this.dgvSales.TabIndex = 1;
            // 
            // lblMonthlyTotal
            // 
            this.lblMonthlyTotal.AutoSize = true;
            this.lblMonthlyTotal.Depth = 0;
            this.lblMonthlyTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMonthlyTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMonthlyTotal.Location = new System.Drawing.Point(287, 636);
            this.lblMonthlyTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMonthlyTotal.Name = "lblMonthlyTotal";
            this.lblMonthlyTotal.Size = new System.Drawing.Size(187, 24);
            this.lblMonthlyTotal.TabIndex = 2;
            this.lblMonthlyTotal.Text = "Monthly Total: ₱0.00";
            // 
            // btnRefresh
            // 
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(811, 629);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 41);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 28;
            this.btnBack.Location = new System.Drawing.Point(16, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(16, 140);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(180, 24);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(16, 184);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(152, 24);
            this.cmbYear.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(16, 236);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 39);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblYearTotal
            // 
            this.lblYearTotal.AutoSize = true;
            this.lblYearTotal.Depth = 0;
            this.lblYearTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblYearTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYearTotal.Location = new System.Drawing.Point(287, 674);
            this.lblYearTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYearTotal.Name = "lblYearTotal";
            this.lblYearTotal.Size = new System.Drawing.Size(15, 24);
            this.lblYearTotal.TabIndex = 9;
            this.lblYearTotal.Text = ":";
            // 
            // Getsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 906);
            this.Controls.Add(this.lblYearTotal);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblMonthlyTotal);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Getsales";
            this.Text = "Getsales";
            this.Load += new System.EventHandler(this.Getsales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvSales;
        private MaterialSkin.Controls.MaterialLabel lblMonthlyTotal;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnFilter;
        private MaterialSkin.Controls.MaterialLabel lblYearTotal;
    }
}