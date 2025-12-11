namespace CoffeeShopPOS
{
    partial class MenuManagementt
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
            this.backBTN = new System.Windows.Forms.Button();
            this.menuDGV = new System.Windows.Forms.DataGridView();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(21, 26);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(153, 53);
            this.backBTN.TabIndex = 11;
            this.backBTN.Text = "RETURN";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // menuDGV
            // 
            this.menuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDGV.Location = new System.Drawing.Point(21, 96);
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.RowHeadersWidth = 51;
            this.menuDGV.RowTemplate.Height = 24;
            this.menuDGV.Size = new System.Drawing.Size(1099, 687);
            this.menuDGV.TabIndex = 10;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(967, 910);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(153, 48);
            this.deleteBTN.TabIndex = 18;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(967, 857);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 47);
            this.button2.TabIndex = 17;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(967, 804);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(153, 47);
            this.addBTN.TabIndex = 16;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(423, 816);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(178, 44);
            this.txtCategory.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(226, 816);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 44);
            this.txtPrice.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 816);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 44);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 797);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 799);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Price";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(428, 803);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(62, 16);
            this.lblcategory.TabIndex = 22;
            this.lblcategory.Text = "Category";
            // 
            // MenuManagementt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 968);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.menuDGV);
            this.Name = "MenuManagementt";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MenuManagementt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.DataGridView menuDGV;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcategory;
    }
}