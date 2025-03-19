namespace GUI.Forms
{
    partial class FormOrder
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txIDCus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.car = new GUI.Car();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txIDCar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.datetimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datetimeStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtCar = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtCus = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
  
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txIDCus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txPhone);
            this.groupBox1.Location = new System.Drawing.Point(46, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txIDCus
            // 
            this.txIDCus.Location = new System.Drawing.Point(319, 25);
            this.txIDCus.Multiline = true;
            this.txIDCus.Name = "txIDCus";
            this.txIDCus.Size = new System.Drawing.Size(77, 42);
            this.txIDCus.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Địa chỉ:";
            // 
            // txAdd
            // 
            this.txAdd.Location = new System.Drawing.Point(29, 328);
            this.txAdd.Multiline = true;
            this.txAdd.Name = "txAdd";
            this.txAdd.Size = new System.Drawing.Size(385, 42);
            this.txAdd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên khách hàng:";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(29, 253);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(385, 42);
            this.txName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(29, 169);
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(385, 42);
            this.txEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số điện thoại:";
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(29, 81);
            this.txPhone.Multiline = true;
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(385, 42);
            this.txPhone.TabIndex = 0;
            this.txPhone.TextChanged += new System.EventHandler(this.txPhone_TextChanged);
            this.txPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPhone_KeyDown);
            // 
            // cbModel
            // 
            this.cbModel.Items.AddRange(new object[] {
            "4 chỗ (Mini)",
            "4 chỗ (Sedan)",
            "4 chỗ (Hatchback)",
            "5 chỗ (CUV Gầm cao)",
            "7 chỗ (SUV Gầm cao)",
            "7 chỗ (MPV Gầm thấp)",
            "Bán tải"});
            this.cbModel.Location = new System.Drawing.Point(29, 95);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(385, 28);
            this.cbModel.TabIndex = 5;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // car
            // 
          
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = this.car;
            this.carBindingSource.Position = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbModel);
            this.groupBox2.Controls.Add(this.txIDCar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(532, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 387);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe  ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá thuê theo ngày";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(29, 279);
            this.txPrice.Multiline = true;
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(385, 42);
            this.txPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã xe";
            // 
            // txIDCar
            // 
            this.txIDCar.Location = new System.Drawing.Point(29, 180);
            this.txIDCar.Multiline = true;
            this.txIDCar.Name = "txIDCar";
            this.txIDCar.Size = new System.Drawing.Size(385, 42);
            this.txIDCar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại xe:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.datetimeEnd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.datetimeStart);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txTotal);
            this.groupBox3.Location = new System.Drawing.Point(46, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 157);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuê";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(834, 49);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(92, 44);
            this.btnRent.TabIndex = 14;
            this.btnRent.Text = "Thuê xe";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày trả:";
            // 
            // datetimeEnd
            // 
            this.datetimeEnd.Location = new System.Drawing.Point(101, 99);
            this.datetimeEnd.Name = "datetimeEnd";
            this.datetimeEnd.Size = new System.Drawing.Size(313, 26);
            this.datetimeEnd.TabIndex = 16;
            this.datetimeEnd.ValueChanged += new System.EventHandler(this.datetimeEnd_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày thuê:";
            // 
            // datetimeStart
            // 
            this.datetimeStart.Location = new System.Drawing.Point(101, 52);
            this.datetimeStart.Name = "datetimeStart";
            this.datetimeStart.Size = new System.Drawing.Size(313, 26);
            this.datetimeStart.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng tiền:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(567, 49);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(261, 44);
            this.txTotal.TabIndex = 0;
            this.txTotal.TextChanged += new System.EventHandler(this.txTotal_TextChanged);
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataSource = this.car;
            this.carBindingSource1.Position = 0;
            // 
            // dtCar
            // 
            this.dtCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtCar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCar.Location = new System.Drawing.Point(998, 60);
            this.dtCar.Name = "dtCar";
            this.dtCar.ReadOnly = true;
            this.dtCar.RowHeadersWidth = 62;
            this.dtCar.RowTemplate.Height = 28;
            this.dtCar.Size = new System.Drawing.Size(569, 378);
            this.dtCar.TabIndex = 15;
            this.dtCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCar_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(998, 456);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 44);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtCus
            // 
            this.dtCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtCus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCus.Location = new System.Drawing.Point(998, 513);
            this.dtCus.Name = "dtCus";
            this.dtCus.ReadOnly = true;
            this.dtCus.RowHeadersWidth = 62;
            this.dtCus.RowTemplate.Height = 28;
            this.dtCus.Size = new System.Drawing.Size(435, 167);
            this.dtCus.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 42);
            this.textBox1.TabIndex = 13;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 698);
            this.Controls.Add(this.dtCus);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtCar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txPhone;
        private Car car;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txIDCar;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datetimeEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datetimeStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txAdd;
        private System.Windows.Forms.TextBox txIDCus;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dtCus;
        private System.Windows.Forms.TextBox textBox1;
    }
}