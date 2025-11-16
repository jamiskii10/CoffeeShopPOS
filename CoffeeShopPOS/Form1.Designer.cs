namespace CoffeeShopPOS
{
    partial class Form1
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
            this.material1 = new MaterialSkin.Controls.MaterialLabel();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBTN = new FontAwesome.Sharp.IconButton();
            this.registerBTN = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // material1
            // 
            this.material1.AutoSize = true;
            this.material1.Depth = 0;
            this.material1.Font = new System.Drawing.Font("Roboto", 11F);
            this.material1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.material1.Location = new System.Drawing.Point(46, 171);
            this.material1.MouseState = MaterialSkin.MouseState.HOVER;
            this.material1.Name = "material1";
            this.material1.Size = new System.Drawing.Size(58, 24);
            this.material1.TabIndex = 1;
            this.material1.Text = "Email";
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(134, 167);
            this.emailTB.MaxLength = 20;
            this.emailTB.Multiline = true;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(292, 32);
            this.emailTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Location = new System.Drawing.Point(134, 205);
            this.passwordTB.MaxLength = 16;
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(292, 32);
            this.passwordTB.TabIndex = 4;
            // 
            // loginBTN
            // 
            this.loginBTN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loginBTN.IconColor = System.Drawing.Color.Black;
            this.loginBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBTN.Location = new System.Drawing.Point(174, 259);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(128, 39);
            this.loginBTN.TabIndex = 5;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // registerBTN
            // 
            this.registerBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registerBTN.IconColor = System.Drawing.Color.Black;
            this.registerBTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registerBTN.Location = new System.Drawing.Point(655, 407);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(133, 31);
            this.registerBTN.TabIndex = 6;
            this.registerBTN.Text = "Register Here!";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopPOS.Properties.Resources.Kope;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.material1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Coffee Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel material1;
        private System.Windows.Forms.TextBox emailTB;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.TextBox passwordTB;
        private FontAwesome.Sharp.IconButton loginBTN;
        private FontAwesome.Sharp.IconButton registerBTN;
    }
}

