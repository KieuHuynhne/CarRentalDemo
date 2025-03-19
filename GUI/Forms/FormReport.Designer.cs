namespace GUI
{
    partial class FormReport
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
            this.dtModel = new System.Windows.Forms.DataGridView();
            this.dtBrand = new System.Windows.Forms.DataGridView();
            this.dtDate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberRent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumberEmpty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnChart = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtModel
            // 
            this.dtModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtModel.Location = new System.Drawing.Point(57, 105);
            this.dtModel.Name = "dtModel";
            this.dtModel.RowHeadersWidth = 62;
            this.dtModel.RowTemplate.Height = 28;
            this.dtModel.Size = new System.Drawing.Size(460, 543);
            this.dtModel.TabIndex = 0;
            this.dtModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtModel_CellContentClick_1);
            // 
            // dtBrand
            // 
            this.dtBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBrand.Location = new System.Drawing.Point(564, 105);
            this.dtBrand.Name = "dtBrand";
            this.dtBrand.RowHeadersWidth = 62;
            this.dtBrand.RowTemplate.Height = 28;
            this.dtBrand.Size = new System.Drawing.Size(460, 543);
            this.dtBrand.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDate.Location = new System.Drawing.Point(1076, 105);
            this.dtDate.Name = "dtDate";
            this.dtDate.RowHeadersWidth = 62;
            this.dtDate.RowTemplate.Height = 28;
            this.dtDate.Size = new System.Drawing.Size(460, 543);
            this.dtDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng và doanh thu theo mẫu xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng và doanh thu theo hãng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1070, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng và doanh thu theo ngày thuê";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.NumberSum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(60, 781);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 211);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // NumberSum
            // 
            this.NumberSum.AutoSize = true;
            this.NumberSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberSum.Location = new System.Drawing.Point(118, 84);
            this.NumberSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberSum.Name = "NumberSum";
            this.NumberSum.Size = new System.Drawing.Size(43, 47);
            this.NumberSum.TabIndex = 1;
            this.NumberSum.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng số xe ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.NumberRent);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(384, 781);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 211);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // NumberRent
            // 
            this.NumberRent.AutoSize = true;
            this.NumberRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberRent.Location = new System.Drawing.Point(122, 84);
            this.NumberRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberRent.Name = "NumberRent";
            this.NumberRent.Size = new System.Drawing.Size(43, 47);
            this.NumberRent.TabIndex = 1;
            this.NumberRent.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số xe đang cho thuê";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.NumberEmpty);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(690, 781);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 211);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // NumberEmpty
            // 
            this.NumberEmpty.AutoSize = true;
            this.NumberEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberEmpty.Location = new System.Drawing.Point(117, 84);
            this.NumberEmpty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberEmpty.Name = "NumberEmpty";
            this.NumberEmpty.Size = new System.Drawing.Size(43, 47);
            this.NumberEmpty.TabIndex = 1;
            this.NumberEmpty.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số xe trống";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(1259, 984);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(8, 8);
            this.cartesianChart1.TabIndex = 9;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnChart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChart.Location = new System.Drawing.Point(57, 668);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(166, 61);
            this.btnChart.TabIndex = 10;
            this.btnChart.Text = "Xem biểu đồ";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkGreen;
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(564, 668);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(166, 61);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "Xem biểu đồ";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkGreen;
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(1074, 668);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(166, 61);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "Xem biểu đồ";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 1050);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.dtBrand);
            this.Controls.Add(this.dtModel);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtModel;
        private System.Windows.Forms.DataGridView dtBrand;
        private System.Windows.Forms.DataGridView dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NumberSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NumberRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NumberEmpty;
        private System.Windows.Forms.Label label9;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}