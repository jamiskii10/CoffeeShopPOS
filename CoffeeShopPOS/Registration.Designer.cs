namespace CoffeeShopPOS
{
    partial class Registration
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.doneBTN = new FontAwesome.Sharp.IconButton();
            this.returnBTN = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(303, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(191, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "USER REGISTRATION";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(243, 107);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Email";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(207, 148);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Password";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(197, 186);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "First Name";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(199, 224);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(102, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Last Name";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(207, 266);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(92, 24);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Contact #";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(307, 97);
            this.emailTB.Multiline = true;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(190, 34);
            this.emailTB.TabIndex = 6;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(307, 137);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(190, 35);
            this.passwordTB.TabIndex = 7;
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(307, 178);
            this.fnameTB.Multiline = true;
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(190, 32);
            this.fnameTB.TabIndex = 8;
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(307, 216);
            this.lnameTB.Multiline = true;
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(190, 32);
            this.lnameTB.TabIndex = 9;
            // 
            // contactTB
            // 
            this.contactTB.Location = new System.Drawing.Point(307, 254);
            this.contactTB.Multiline = true;
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(190, 36);
            this.contactTB.TabIndex = 10;
            // 
            // doneBTN
            // 
            this.doneBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.doneBTN.IconColor = System.Drawing.Color.Black;
            this.doneBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.doneBTN.Location = new System.Drawing.Point(328, 320);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(160, 39);
            this.doneBTN.TabIndex = 11;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = true;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // returnBTN
            // 
            this.returnBTN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.returnBTN.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.returnBTN.IconColor = System.Drawing.Color.Black;
            this.returnBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.returnBTN.IconSize = 28;
            this.returnBTN.Location = new System.Drawing.Point(12, 12);
            this.returnBTN.Name = "returnBTN";
            this.returnBTN.Size = new System.Drawing.Size(54, 44);
            this.returnBTN.TabIndex = 12;
            this.returnBTN.UseVisualStyleBackColor = false;
            this.returnBTN.Click += new System.EventHandler(this.returnBTN_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnBTN);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.contactTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox contactTB;
        private FontAwesome.Sharp.IconButton doneBTN;
        private FontAwesome.Sharp.IconButton returnBTN;
    }
}