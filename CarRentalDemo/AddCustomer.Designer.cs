namespace CarRentalDemo
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new MetroFramework.Controls.MetroTextBox();
            this.userAdd = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userPhone = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userEmail = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(661, 604);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 42);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm khách hàng";
            this.btnAdd.UseSelectable = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "<< Quay lại";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ và tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            // 
            // 
            // 
            this.userName.CustomButton.Image = null;
            this.userName.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.userName.CustomButton.Name = "";
            this.userName.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userName.CustomButton.TabIndex = 1;
            this.userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userName.CustomButton.UseSelectable = true;
            this.userName.CustomButton.Visible = false;
            this.userName.Lines = new string[0];
            this.userName.Location = new System.Drawing.Point(381, 169);
            this.userName.MaxLength = 32767;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.ShortcutsEnabled = true;
            this.userName.Size = new System.Drawing.Size(446, 46);
            this.userName.TabIndex = 15;
            this.userName.UseSelectable = true;
            this.userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userName.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // userAdd
            // 
            // 
            // 
            // 
            this.userAdd.CustomButton.Image = null;
            this.userAdd.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.userAdd.CustomButton.Name = "";
            this.userAdd.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.userAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userAdd.CustomButton.TabIndex = 1;
            this.userAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userAdd.CustomButton.UseSelectable = true;
            this.userAdd.CustomButton.Visible = false;
            this.userAdd.Lines = new string[0];
            this.userAdd.Location = new System.Drawing.Point(381, 280);
            this.userAdd.MaxLength = 32767;
            this.userAdd.Name = "userAdd";
            this.userAdd.PasswordChar = '\0';
            this.userAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userAdd.SelectedText = "";
            this.userAdd.SelectionLength = 0;
            this.userAdd.SelectionStart = 0;
            this.userAdd.ShortcutsEnabled = true;
            this.userAdd.Size = new System.Drawing.Size(446, 46);
            this.userAdd.TabIndex = 17;
            this.userAdd.UseSelectable = true;
            this.userAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Địa chỉ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userPhone
            // 
            // 
            // 
            // 
            this.userPhone.CustomButton.Image = null;
            this.userPhone.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.userPhone.CustomButton.Name = "";
            this.userPhone.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.userPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userPhone.CustomButton.TabIndex = 1;
            this.userPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userPhone.CustomButton.UseSelectable = true;
            this.userPhone.CustomButton.Visible = false;
            this.userPhone.Lines = new string[0];
            this.userPhone.Location = new System.Drawing.Point(381, 396);
            this.userPhone.MaxLength = 32767;
            this.userPhone.Name = "userPhone";
            this.userPhone.PasswordChar = '\0';
            this.userPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userPhone.SelectedText = "";
            this.userPhone.SelectionLength = 0;
            this.userPhone.SelectionStart = 0;
            this.userPhone.ShortcutsEnabled = true;
            this.userPhone.Size = new System.Drawing.Size(446, 46);
            this.userPhone.TabIndex = 19;
            this.userPhone.UseSelectable = true;
            this.userPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Điện thoại:";
            // 
            // userEmail
            // 
            // 
            // 
            // 
            this.userEmail.CustomButton.Image = null;
            this.userEmail.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.userEmail.CustomButton.Name = "";
            this.userEmail.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.userEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userEmail.CustomButton.TabIndex = 1;
            this.userEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userEmail.CustomButton.UseSelectable = true;
            this.userEmail.CustomButton.Visible = false;
            this.userEmail.Lines = new string[0];
            this.userEmail.Location = new System.Drawing.Point(381, 509);
            this.userEmail.MaxLength = 32767;
            this.userEmail.Name = "userEmail";
            this.userEmail.PasswordChar = '\0';
            this.userEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userEmail.SelectedText = "";
            this.userEmail.SelectionLength = 0;
            this.userEmail.SelectionStart = 0;
            this.userEmail.ShortcutsEnabled = true;
            this.userEmail.Size = new System.Drawing.Size(446, 46);
            this.userEmail.TabIndex = 21;
            this.userEmail.UseSelectable = true;
            this.userEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 674);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox userName;
        private MetroFramework.Controls.MetroTextBox userAdd;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox userPhone;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox userEmail;
        private System.Windows.Forms.Label label4;
    }
}