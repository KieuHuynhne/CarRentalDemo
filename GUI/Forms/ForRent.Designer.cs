namespace GUI.Forms
{
    partial class ForRent
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
            this.btn1 = new System.Windows.Forms.Button();
            this.gbModel = new System.Windows.Forms.GroupBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.gbFunc = new System.Windows.Forms.GroupBox();
            this.cb14 = new System.Windows.Forms.CheckBox();
            this.cb13 = new System.Windows.Forms.CheckBox();
            this.cb12 = new System.Windows.Forms.CheckBox();
            this.cb11 = new System.Windows.Forms.CheckBox();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.cb9 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCarRent = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbDemo = new System.Windows.Forms.TextBox();
            this.gbModel.SuspendLayout();
            this.gbFunc.SuspendLayout();
            this.gbFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRent)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(43, 68);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 180);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "4 chỗ (mini)";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // gbModel
            // 
            this.gbModel.Controls.Add(this.btn7);
            this.gbModel.Controls.Add(this.btn6);
            this.gbModel.Controls.Add(this.btn5);
            this.gbModel.Controls.Add(this.btn4);
            this.gbModel.Controls.Add(this.btn3);
            this.gbModel.Controls.Add(this.btn2);
            this.gbModel.Controls.Add(this.btn1);
            this.gbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModel.Location = new System.Drawing.Point(12, 12);
            this.gbModel.Name = "gbModel";
            this.gbModel.Size = new System.Drawing.Size(892, 490);
            this.gbModel.TabIndex = 1;
            this.gbModel.TabStop = false;
            this.gbModel.Text = "LOẠI XE";
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(465, 273);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(180, 180);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Bán tải";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(250, 273);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(180, 180);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "7 chỗ (MPV Gầm thấp)";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(43, 273);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(180, 180);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "7 chỗ (SUV gầm cao)";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(676, 68);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(180, 180);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "5 chỗ (CUV Gầm cao)";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(465, 68);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(180, 180);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "4 chỗ (Hatchback)";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(250, 68);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(180, 180);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "4 chỗ (Sedan)";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // gbFunc
            // 
            this.gbFunc.Controls.Add(this.cb14);
            this.gbFunc.Controls.Add(this.cb13);
            this.gbFunc.Controls.Add(this.cb12);
            this.gbFunc.Controls.Add(this.cb11);
            this.gbFunc.Controls.Add(this.cb10);
            this.gbFunc.Controls.Add(this.cb9);
            this.gbFunc.Controls.Add(this.cb8);
            this.gbFunc.Controls.Add(this.cb7);
            this.gbFunc.Controls.Add(this.cb6);
            this.gbFunc.Controls.Add(this.cb5);
            this.gbFunc.Controls.Add(this.cb4);
            this.gbFunc.Controls.Add(this.cb3);
            this.gbFunc.Controls.Add(this.cb2);
            this.gbFunc.Controls.Add(this.cb1);
            this.gbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFunc.Location = new System.Drawing.Point(12, 508);
            this.gbFunc.Name = "gbFunc";
            this.gbFunc.Size = new System.Drawing.Size(892, 277);
            this.gbFunc.TabIndex = 2;
            this.gbFunc.TabStop = false;
            this.gbFunc.Text = "TÍNH NĂNG";
            // 
            // cb14
            // 
            this.cb14.AutoSize = true;
            this.cb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb14.Location = new System.Drawing.Point(574, 78);
            this.cb14.Name = "cb14";
            this.cb14.Size = new System.Drawing.Size(152, 24);
            this.cb14.TabIndex = 13;
            this.cb14.Text = "Cảnh báo tốc độ";
            this.cb14.UseVisualStyleBackColor = true;
            this.cb14.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb13
            // 
            this.cb13.AutoSize = true;
            this.cb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb13.Location = new System.Drawing.Point(574, 39);
            this.cb13.Name = "cb13";
            this.cb13.Size = new System.Drawing.Size(110, 24);
            this.cb13.TabIndex = 12;
            this.cb13.Text = "Camera lùi";
            this.cb13.UseVisualStyleBackColor = true;
            this.cb13.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb12
            // 
            this.cb12.AutoSize = true;
            this.cb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb12.Location = new System.Drawing.Point(302, 230);
            this.cb12.Name = "cb12";
            this.cb12.Size = new System.Drawing.Size(122, 24);
            this.cb12.TabIndex = 11;
            this.cb12.Text = "Camera 360";
            this.cb12.UseVisualStyleBackColor = true;
            this.cb12.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb11
            // 
            this.cb11.AutoSize = true;
            this.cb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb11.Location = new System.Drawing.Point(302, 193);
            this.cb11.Name = "cb11";
            this.cb11.Size = new System.Drawing.Size(133, 24);
            this.cb11.TabIndex = 10;
            this.cb11.Text = "Lốp dự phòng";
            this.cb11.UseVisualStyleBackColor = true;
            this.cb11.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb10.Location = new System.Drawing.Point(302, 156);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(120, 24);
            this.cb10.TabIndex = 9;
            this.cb10.Text = "Định vị GPS";
            this.cb10.UseVisualStyleBackColor = true;
            this.cb10.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb9
            // 
            this.cb9.AutoSize = true;
            this.cb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb9.Location = new System.Drawing.Point(302, 117);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(165, 24);
            this.cb9.TabIndex = 8;
            this.cb9.Text = "Cảm biến va chạm";
            this.cb9.UseVisualStyleBackColor = true;
            this.cb9.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb8.Location = new System.Drawing.Point(302, 78);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(166, 24);
            this.cb8.TabIndex = 7;
            this.cb8.Text = "Camera hành trình";
            this.cb8.UseVisualStyleBackColor = true;
            this.cb8.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb7.Location = new System.Drawing.Point(302, 39);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(104, 24);
            this.cb7.TabIndex = 6;
            this.cb7.Text = "Bluetooth";
            this.cb7.UseVisualStyleBackColor = true;
            this.cb7.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb6.Location = new System.Drawing.Point(23, 230);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(181, 24);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "Nắp thùng xe bán tải";
            this.cb6.UseVisualStyleBackColor = true;
            this.cb6.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.Location = new System.Drawing.Point(23, 193);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(135, 24);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "Khe cắm USB";
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.Location = new System.Drawing.Point(23, 156);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(111, 24);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Cửa sổ trời";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.Location = new System.Drawing.Point(23, 117);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(127, 24);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Cảm biến lốp";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.Location = new System.Drawing.Point(23, 78);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(137, 24);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Camera cập lề";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.Click += new System.EventHandler(this.cbFunction);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Location = new System.Drawing.Point(23, 39);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(86, 24);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Bản đồ";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.Click += new System.EventHandler(this.cbFunction);
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.r4);
            this.gbFuel.Controls.Add(this.r3);
            this.gbFuel.Controls.Add(this.r2);
            this.gbFuel.Controls.Add(this.r1);
            this.gbFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuel.Location = new System.Drawing.Point(12, 791);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(645, 97);
            this.gbFuel.TabIndex = 3;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "NHIÊN LIỆU";
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r4.Location = new System.Drawing.Point(479, 43);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(67, 24);
            this.r4.TabIndex = 3;
            this.r4.TabStop = true;
            this.r4.Text = "Điện";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3.Location = new System.Drawing.Point(274, 43);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(112, 24);
            this.r3.TabIndex = 2;
            this.r3.TabStop = true;
            this.r3.Text = "Dầu Diesel";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.Location = new System.Drawing.Point(152, 43);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(72, 24);
            this.r2.TabIndex = 1;
            this.r2.TabStop = true;
            this.r2.Text = "Xăng";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.Location = new System.Drawing.Point(23, 43);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(78, 24);
            this.r1.TabIndex = 0;
            this.r1.TabStop = true;
            this.r1.Text = "Tất cả";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(922, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH XE KHẢ DỤNG";
            // 
            // dtCarRent
            // 
            this.dtCarRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarRent.Location = new System.Drawing.Point(927, 71);
            this.dtCarRent.Name = "dtCarRent";
            this.dtCarRent.RowHeadersWidth = 62;
            this.dtCarRent.RowTemplate.Height = 28;
            this.dtCarRent.Size = new System.Drawing.Size(702, 714);
            this.dtCarRent.TabIndex = 5;
            this.dtCarRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCarRent_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(688, 805);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(216, 83);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "TÌM XE";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbDemo
            // 
            this.tbDemo.Location = new System.Drawing.Point(994, 820);
            this.tbDemo.Multiline = true;
            this.tbDemo.Name = "tbDemo";
            this.tbDemo.Size = new System.Drawing.Size(200, 77);
            this.tbDemo.TabIndex = 7;
            this.tbDemo.TextChanged += new System.EventHandler(this.tbDemo_TextChanged);
            // 
            // ForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1837, 1050);
            this.Controls.Add(this.tbDemo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtCarRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFuel);
            this.Controls.Add(this.gbFunc);
            this.Controls.Add(this.gbModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForRent";
            this.Text = "ForRent";
            this.Load += new System.EventHandler(this.ForRent_Load);
            this.gbModel.ResumeLayout(false);
            this.gbFunc.ResumeLayout(false);
            this.gbFunc.PerformLayout();
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCarRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox gbModel;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.GroupBox gbFunc;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb12;
        private System.Windows.Forms.CheckBox cb11;
        private System.Windows.Forms.CheckBox cb10;
        private System.Windows.Forms.CheckBox cb9;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb14;
        private System.Windows.Forms.CheckBox cb13;
        private System.Windows.Forms.GroupBox gbFuel;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtCarRent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbDemo;
    }
}