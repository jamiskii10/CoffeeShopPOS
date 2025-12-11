namespace CoffeeShopPOS
{
    partial class ReceiptForm
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.panelright = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.gbReceiptInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panelright.SuspendLayout();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.gbReceiptInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeight = 29;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.Size = new System.Drawing.Size(495, 468);
            this.dgvOrderList.TabIndex = 0;
            this.dgvOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.dgvOrderList);
            this.panelright.Location = new System.Drawing.Point(29, 117);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(498, 471);
            this.panelright.TabIndex = 1;
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.dgvOrderItems);
            this.panelleft.Controls.Add(this.gbReceiptInfo);
            this.panelleft.Location = new System.Drawing.Point(541, 121);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(495, 464);
            this.panelleft.TabIndex = 2;
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(24, 173);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.Size = new System.Drawing.Size(457, 274);
            this.dgvOrderItems.TabIndex = 1;
            this.dgvOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellClick);
            // 
            // gbReceiptInfo
            // 
            this.gbReceiptInfo.Controls.Add(this.lblTotalAmount);
            this.gbReceiptInfo.Controls.Add(this.lblOrderDate);
            this.gbReceiptInfo.Controls.Add(this.lblUserName);
            this.gbReceiptInfo.Controls.Add(this.lblCustomerName);
            this.gbReceiptInfo.Location = new System.Drawing.Point(17, 10);
            this.gbReceiptInfo.Name = "gbReceiptInfo";
            this.gbReceiptInfo.Size = new System.Drawing.Size(464, 143);
            this.gbReceiptInfo.TabIndex = 0;
            this.gbReceiptInfo.TabStop = false;
            this.gbReceiptInfo.Text = "Receipt Information";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(272, 103);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(89, 16);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(16, 103);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(76, 16);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(16, 71);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User in Charge:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(16, 37);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(107, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "RECEIPT SECTION";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 36);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btnRefresh.IconColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 30;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(29, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(244, 41);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Update OR";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 611);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panelright);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.gbReceiptInfo.ResumeLayout(false);
            this.gbReceiptInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.GroupBox gbReceiptInfo;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private FontAwesome.Sharp.IconButton btnRefresh;
    }
}