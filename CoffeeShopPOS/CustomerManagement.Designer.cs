namespace CoffeeShopPOS
{
    partial class CustomerManagement
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
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.custIDTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDGV
            // 
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Location = new System.Drawing.Point(12, 82);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.RowHeadersWidth = 51;
            this.customerDGV.RowTemplate.Height = 24;
            this.customerDGV.Size = new System.Drawing.Size(783, 770);
            this.customerDGV.TabIndex = 0;
            this.customerDGV.SelectionChanged += new System.EventHandler(this.customerDGV_SelectionChanged);
            // 
            // custIDTB
            // 
            this.custIDTB.Location = new System.Drawing.Point(840, 82);
            this.custIDTB.Multiline = true;
            this.custIDTB.Name = "custIDTB";
            this.custIDTB.Size = new System.Drawing.Size(260, 46);
            this.custIDTB.TabIndex = 1;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(840, 153);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(260, 46);
            this.nameTB.TabIndex = 2;
            // 
            // contactTB
            // 
            this.contactTB.Location = new System.Drawing.Point(840, 228);
            this.contactTB.Multiline = true;
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(260, 47);
            this.contactTB.TabIndex = 3;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(900, 316);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(143, 38);
            this.addBTN.TabIndex = 4;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(900, 374);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(143, 38);
            this.updateBTN.TabIndex = 5;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(900, 429);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(143, 40);
            this.deleteBTN.TabIndex = 6;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(12, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(130, 41);
            this.backBTN.TabIndex = 7;
            this.backBTN.Text = "RETURN";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(845, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact";
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.contactTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.custIDTB);
            this.Controls.Add(this.customerDGV);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.TextBox custIDTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}