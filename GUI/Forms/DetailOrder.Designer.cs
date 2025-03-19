namespace GUI.Forms
{
    partial class DetailOrder
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
            this.txOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dtOrder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txStatus = new System.Windows.Forms.TextBox();
            this.txFuel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txBrand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txFunction = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txNsx = new System.Windows.Forms.TextBox();
            this.txModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txIDCar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txIDCus = new System.Windows.Forms.TextBox();
            this.txDayStart = new System.Windows.Forms.TextBox();
            this.txDayEnd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txOrderID
            // 
            this.txOrderID.Location = new System.Drawing.Point(129, 750);
            this.txOrderID.Multiline = true;
            this.txOrderID.Name = "txOrderID";
            this.txOrderID.Size = new System.Drawing.Size(317, 36);
            this.txOrderID.TabIndex = 1;
            this.txOrderID.TextChanged += new System.EventHandler(this.txOrderID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 753);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn:";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(466, 750);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(229, 36);
            this.btnChiTiet.TabIndex = 3;
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // dtOrder
            // 
            this.dtOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOrder.Location = new System.Drawing.Point(12, 6);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.ReadOnly = true;
            this.dtOrder.RowHeadersWidth = 62;
            this.dtOrder.RowTemplate.Height = 28;
            this.dtOrder.Size = new System.Drawing.Size(683, 718);
            this.dtOrder.TabIndex = 15;
            this.dtOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtOrder_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txStatus);
            this.groupBox2.Controls.Add(this.txFuel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txBrand);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txFunction);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txNsx);
            this.groupBox2.Controls.Add(this.txModel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txIDCar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(714, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 387);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe  ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(432, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Trạng thái: ";
            // 
            // txStatus
            // 
            this.txStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txStatus.Location = new System.Drawing.Point(436, 328);
            this.txStatus.Multiline = true;
            this.txStatus.Name = "txStatus";
            this.txStatus.ReadOnly = true;
            this.txStatus.Size = new System.Drawing.Size(380, 40);
            this.txStatus.TabIndex = 44;
            // 
            // txFuel
            // 
            this.txFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFuel.Location = new System.Drawing.Point(436, 148);
            this.txFuel.Multiline = true;
            this.txFuel.Name = "txFuel";
            this.txFuel.ReadOnly = true;
            this.txFuel.Size = new System.Drawing.Size(380, 40);
            this.txFuel.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Hãng: ";
            // 
            // txBrand
            // 
            this.txBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBrand.Location = new System.Drawing.Point(23, 238);
            this.txBrand.Multiline = true;
            this.txBrand.Name = "txBrand";
            this.txBrand.ReadOnly = true;
            this.txBrand.Size = new System.Drawing.Size(385, 40);
            this.txBrand.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tính năng: ";
            // 
            // txFunction
            // 
            this.txFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFunction.Location = new System.Drawing.Point(436, 238);
            this.txFunction.Multiline = true;
            this.txFunction.Name = "txFunction";
            this.txFunction.ReadOnly = true;
            this.txFunction.Size = new System.Drawing.Size(380, 40);
            this.txFunction.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Loại nhiên liệu: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(432, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nhà sản xuất: ";
            // 
            // txNsx
            // 
            this.txNsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNsx.Location = new System.Drawing.Point(436, 74);
            this.txNsx.Multiline = true;
            this.txNsx.Name = "txNsx";
            this.txNsx.ReadOnly = true;
            this.txNsx.Size = new System.Drawing.Size(380, 42);
            this.txNsx.TabIndex = 34;
            // 
            // txModel
            // 
            this.txModel.Location = new System.Drawing.Point(23, 148);
            this.txModel.Multiline = true;
            this.txModel.Name = "txModel";
            this.txModel.ReadOnly = true;
            this.txModel.Size = new System.Drawing.Size(385, 42);
            this.txModel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá thuê theo ngày";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(23, 328);
            this.txPrice.Multiline = true;
            this.txPrice.Name = "txPrice";
            this.txPrice.ReadOnly = true;
            this.txPrice.Size = new System.Drawing.Size(385, 42);
            this.txPrice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã xe";
            // 
            // txIDCar
            // 
            this.txIDCar.Location = new System.Drawing.Point(23, 74);
            this.txIDCar.Multiline = true;
            this.txIDCar.Name = "txIDCar";
            this.txIDCar.ReadOnly = true;
            this.txIDCar.Size = new System.Drawing.Size(385, 42);
            this.txIDCar.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại xe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txPhone);
            this.groupBox1.Location = new System.Drawing.Point(714, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 387);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Địa chỉ:";
            // 
            // txAdd
            // 
            this.txAdd.Location = new System.Drawing.Point(23, 309);
            this.txAdd.Multiline = true;
            this.txAdd.Name = "txAdd";
            this.txAdd.ReadOnly = true;
            this.txAdd.Size = new System.Drawing.Size(385, 42);
            this.txAdd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên khách hàng:";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(23, 234);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.ReadOnly = true;
            this.txName.Size = new System.Drawing.Size(385, 42);
            this.txName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(23, 150);
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.ReadOnly = true;
            this.txEmail.Size = new System.Drawing.Size(385, 42);
            this.txEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(23, 62);
            this.txPhone.Multiline = true;
            this.txPhone.Name = "txPhone";
            this.txPhone.ReadOnly = true;
            this.txPhone.Size = new System.Drawing.Size(385, 42);
            this.txPhone.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txIDCus);
            this.groupBox3.Controls.Add(this.txDayStart);
            this.groupBox3.Controls.Add(this.txDayEnd);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txTotal);
            this.groupBox3.Location = new System.Drawing.Point(1166, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 378);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuê";
            // 
            // txIDCus
            // 
            this.txIDCus.Location = new System.Drawing.Point(26, 336);
            this.txIDCus.Multiline = true;
            this.txIDCus.Name = "txIDCus";
            this.txIDCus.Size = new System.Drawing.Size(77, 36);
            this.txIDCus.TabIndex = 20;
            // 
            // txDayStart
            // 
            this.txDayStart.Location = new System.Drawing.Point(28, 94);
            this.txDayStart.Multiline = true;
            this.txDayStart.Name = "txDayStart";
            this.txDayStart.ReadOnly = true;
            this.txDayStart.Size = new System.Drawing.Size(354, 44);
            this.txDayStart.TabIndex = 19;
            // 
            // txDayEnd
            // 
            this.txDayEnd.Location = new System.Drawing.Point(28, 185);
            this.txDayEnd.Multiline = true;
            this.txDayEnd.Name = "txDayEnd";
            this.txDayEnd.ReadOnly = true;
            this.txDayEnd.Size = new System.Drawing.Size(354, 44);
            this.txDayEnd.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Ngày trả:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Ngày thuê:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Tổng tiền:";
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(28, 277);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(354, 44);
            this.txTotal.TabIndex = 0;
            // 
            // DetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 805);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txOrderID);
            this.Name = "DetailOrder";
            this.Text = "DetailOrder";
            this.Load += new System.EventHandler(this.DetailOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.DataGridView dtOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txFuel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txFunction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txNsx;
        private System.Windows.Forms.TextBox txModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txIDCar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPhone;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.TextBox txDayStart;
        private System.Windows.Forms.TextBox txDayEnd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txStatus;
        private System.Windows.Forms.TextBox txIDCus;
    }
}