namespace CarRentalDemo
{
    partial class QuanLyXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txModel = new MetroFramework.Controls.MetroTextBox();
            this.txFactory = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txFuel = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txFunction = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.GridViewCar = new MetroFramework.Controls.MetroGrid();
            this.txCost = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tvSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 604);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 42);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.label1.Location = new System.Drawing.Point(290, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Model:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txModel
            // 
            // 
            // 
            // 
            this.txModel.CustomButton.Image = null;
            this.txModel.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txModel.CustomButton.Name = "";
            this.txModel.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txModel.CustomButton.TabIndex = 1;
            this.txModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txModel.CustomButton.UseSelectable = true;
            this.txModel.CustomButton.Visible = false;
            this.txModel.Lines = new string[0];
            this.txModel.Location = new System.Drawing.Point(294, 132);
            this.txModel.MaxLength = 32767;
            this.txModel.Name = "txModel";
            this.txModel.PasswordChar = '\0';
            this.txModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txModel.SelectedText = "";
            this.txModel.SelectionLength = 0;
            this.txModel.SelectionStart = 0;
            this.txModel.ShortcutsEnabled = true;
            this.txModel.Size = new System.Drawing.Size(446, 46);
            this.txModel.TabIndex = 15;
            this.txModel.UseSelectable = true;
            this.txModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txModel.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txFactory
            // 
            // 
            // 
            // 
            this.txFactory.CustomButton.Image = null;
            this.txFactory.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txFactory.CustomButton.Name = "";
            this.txFactory.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txFactory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txFactory.CustomButton.TabIndex = 1;
            this.txFactory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txFactory.CustomButton.UseSelectable = true;
            this.txFactory.CustomButton.Visible = false;
            this.txFactory.Lines = new string[0];
            this.txFactory.Location = new System.Drawing.Point(294, 224);
            this.txFactory.MaxLength = 32767;
            this.txFactory.Name = "txFactory";
            this.txFactory.PasswordChar = '\0';
            this.txFactory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFactory.SelectedText = "";
            this.txFactory.SelectionLength = 0;
            this.txFactory.SelectionStart = 0;
            this.txFactory.ShortcutsEnabled = true;
            this.txFactory.Size = new System.Drawing.Size(446, 46);
            this.txFactory.TabIndex = 17;
            this.txFactory.UseSelectable = true;
            this.txFactory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txFactory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhà sản xuất:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txFuel
            // 
            // 
            // 
            // 
            this.txFuel.CustomButton.Image = null;
            this.txFuel.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txFuel.CustomButton.Name = "";
            this.txFuel.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txFuel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txFuel.CustomButton.TabIndex = 1;
            this.txFuel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txFuel.CustomButton.UseSelectable = true;
            this.txFuel.CustomButton.Visible = false;
            this.txFuel.Lines = new string[0];
            this.txFuel.Location = new System.Drawing.Point(295, 307);
            this.txFuel.MaxLength = 32767;
            this.txFuel.Name = "txFuel";
            this.txFuel.PasswordChar = '\0';
            this.txFuel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFuel.SelectedText = "";
            this.txFuel.SelectionLength = 0;
            this.txFuel.SelectionStart = 0;
            this.txFuel.ShortcutsEnabled = true;
            this.txFuel.Size = new System.Drawing.Size(446, 46);
            this.txFuel.TabIndex = 19;
            this.txFuel.UseSelectable = true;
            this.txFuel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txFuel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhiên liệu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txFunction
            // 
            // 
            // 
            // 
            this.txFunction.CustomButton.Image = null;
            this.txFunction.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txFunction.CustomButton.Name = "";
            this.txFunction.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txFunction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txFunction.CustomButton.TabIndex = 1;
            this.txFunction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txFunction.CustomButton.UseSelectable = true;
            this.txFunction.CustomButton.Visible = false;
            this.txFunction.Lines = new string[0];
            this.txFunction.Location = new System.Drawing.Point(294, 402);
            this.txFunction.MaxLength = 32767;
            this.txFunction.Name = "txFunction";
            this.txFunction.PasswordChar = '\0';
            this.txFunction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFunction.SelectedText = "";
            this.txFunction.SelectionLength = 0;
            this.txFunction.SelectionStart = 0;
            this.txFunction.ShortcutsEnabled = true;
            this.txFunction.Size = new System.Drawing.Size(446, 46);
            this.txFunction.TabIndex = 21;
            this.txFunction.UseSelectable = true;
            this.txFunction.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txFunction.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tính năng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(715, 604);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(135, 42);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(504, 604);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 42);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GridViewCar
            // 
            this.GridViewCar.AllowUserToResizeRows = false;
            this.GridViewCar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewCar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridViewCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewCar.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridViewCar.EnableHeadersVisualStyles = false;
            this.GridViewCar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridViewCar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridViewCar.Location = new System.Drawing.Point(792, 201);
            this.GridViewCar.Name = "GridViewCar";
            this.GridViewCar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridViewCar.RowHeadersWidth = 62;
            this.GridViewCar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewCar.RowTemplate.Height = 28;
            this.GridViewCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewCar.Size = new System.Drawing.Size(810, 339);
            this.GridViewCar.TabIndex = 24;
            this.GridViewCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // txCost
            // 
            // 
            // 
            // 
            this.txCost.CustomButton.Image = null;
            this.txCost.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txCost.CustomButton.Name = "";
            this.txCost.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txCost.CustomButton.TabIndex = 1;
            this.txCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txCost.CustomButton.UseSelectable = true;
            this.txCost.CustomButton.Visible = false;
            this.txCost.Lines = new string[0];
            this.txCost.Location = new System.Drawing.Point(294, 494);
            this.txCost.MaxLength = 32767;
            this.txCost.Name = "txCost";
            this.txCost.PasswordChar = '\0';
            this.txCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txCost.SelectedText = "";
            this.txCost.SelectionLength = 0;
            this.txCost.SelectionStart = 0;
            this.txCost.ShortcutsEnabled = true;
            this.txCost.Size = new System.Drawing.Size(446, 46);
            this.txCost.TabIndex = 26;
            this.txCost.UseSelectable = true;
            this.txCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txCost.Click += new System.EventHandler(this.metroTextBox1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Giá thuê theo ngày:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tvSearch
            // 
            // 
            // 
            // 
            this.tvSearch.CustomButton.Image = null;
            this.tvSearch.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.tvSearch.CustomButton.Name = "";
            this.tvSearch.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.tvSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tvSearch.CustomButton.TabIndex = 1;
            this.tvSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tvSearch.CustomButton.UseSelectable = true;
            this.tvSearch.CustomButton.Visible = false;
            this.tvSearch.Lines = new string[0];
            this.tvSearch.Location = new System.Drawing.Point(1142, 138);
            this.tvSearch.MaxLength = 32767;
            this.tvSearch.Name = "tvSearch";
            this.tvSearch.PasswordChar = '\0';
            this.tvSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tvSearch.SelectedText = "";
            this.tvSearch.SelectionLength = 0;
            this.tvSearch.SelectionStart = 0;
            this.tvSearch.ShortcutsEnabled = true;
            this.tvSearch.Size = new System.Drawing.Size(276, 40);
            this.tvSearch.TabIndex = 27;
            this.tvSearch.UseSelectable = true;
            this.tvSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tvSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1436, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 40);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseSelectable = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(931, 604);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 42);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // QuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 674);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tvSearch);
            this.Controls.Add(this.txCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GridViewCar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txFunction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txFuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txFactory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuanLyXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý xe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txModel;
        private MetroFramework.Controls.MetroTextBox txFactory;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txFuel;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txFunction;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroGrid GridViewCar;
        private MetroFramework.Controls.MetroTextBox txCost;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox tvSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnReset;
    }
}