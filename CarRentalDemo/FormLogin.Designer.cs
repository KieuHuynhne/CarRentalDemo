namespace CarRentalDemo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.User = new MetroFramework.Controls.MetroLabel();
            this.passw = new MetroFramework.Controls.MetroLabel();
            this.TxUserLogin = new MetroFramework.Controls.MetroTextBox();
            this.TxUserPass = new MetroFramework.Controls.MetroTextBox();
            this.saveLogin = new MetroFramework.Controls.MetroCheckBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(318, 124);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(98, 19);
            this.User.TabIndex = 0;
            this.User.Text = "Tên đăng nhập:";
            this.User.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // passw
            // 
            this.passw.AutoSize = true;
            this.passw.Location = new System.Drawing.Point(318, 202);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(66, 19);
            this.passw.TabIndex = 1;
            this.passw.Text = "Mật khẩu:";
            this.passw.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // TxUserLogin
            // 
            // 
            // 
            // 
            this.TxUserLogin.CustomButton.Image = null;
            this.TxUserLogin.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.TxUserLogin.CustomButton.Name = "";
            this.TxUserLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxUserLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxUserLogin.CustomButton.TabIndex = 1;
            this.TxUserLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxUserLogin.CustomButton.UseSelectable = true;
            this.TxUserLogin.CustomButton.Visible = false;
            this.TxUserLogin.Lines = new string[0];
            this.TxUserLogin.Location = new System.Drawing.Point(318, 156);
            this.TxUserLogin.MaxLength = 32767;
            this.TxUserLogin.Name = "TxUserLogin";
            this.TxUserLogin.PasswordChar = '\0';
            this.TxUserLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxUserLogin.SelectedText = "";
            this.TxUserLogin.SelectionLength = 0;
            this.TxUserLogin.SelectionStart = 0;
            this.TxUserLogin.ShortcutsEnabled = true;
            this.TxUserLogin.Size = new System.Drawing.Size(306, 30);
            this.TxUserLogin.TabIndex = 2;
            this.TxUserLogin.UseSelectable = true;
            this.TxUserLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxUserLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxUserPass
            // 
            // 
            // 
            // 
            this.TxUserPass.CustomButton.Image = null;
            this.TxUserPass.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.TxUserPass.CustomButton.Name = "";
            this.TxUserPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxUserPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxUserPass.CustomButton.TabIndex = 1;
            this.TxUserPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxUserPass.CustomButton.UseSelectable = true;
            this.TxUserPass.CustomButton.Visible = false;
            this.TxUserPass.Lines = new string[0];
            this.TxUserPass.Location = new System.Drawing.Point(318, 234);
            this.TxUserPass.MaxLength = 32767;
            this.TxUserPass.Name = "TxUserPass";
            this.TxUserPass.PasswordChar = '\0';
            this.TxUserPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxUserPass.SelectedText = "";
            this.TxUserPass.SelectionLength = 0;
            this.TxUserPass.SelectionStart = 0;
            this.TxUserPass.ShortcutsEnabled = true;
            this.TxUserPass.Size = new System.Drawing.Size(306, 30);
            this.TxUserPass.TabIndex = 3;
            this.TxUserPass.UseSelectable = true;
            this.TxUserPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxUserPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // saveLogin
            // 
            this.saveLogin.AutoSize = true;
            this.saveLogin.Location = new System.Drawing.Point(318, 285);
            this.saveLogin.Name = "saveLogin";
            this.saveLogin.Size = new System.Drawing.Size(103, 15);
            this.saveLogin.TabIndex = 4;
            this.saveLogin.Text = "Lưu đăng nhập";
            this.saveLogin.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(475, 336);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 41);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 163);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 41);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.saveLogin);
            this.Controls.Add(this.TxUserPass);
            this.Controls.Add(this.TxUserLogin);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.User);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel User;
        private MetroFramework.Controls.MetroLabel passw;
        private MetroFramework.Controls.MetroTextBox TxUserLogin;
        private MetroFramework.Controls.MetroTextBox TxUserPass;
        private MetroFramework.Controls.MetroCheckBox saveLogin;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}

