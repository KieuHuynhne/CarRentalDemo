namespace GUI.Forms
{
    partial class FormCar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNsx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtCar = new System.Windows.Forms.DataGridView();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.txID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txBrand = new System.Windows.Forms.TextBox();
            this.txFuel = new System.Windows.Forms.ComboBox();
            this.txModel = new System.Windows.Forms.ComboBox();
            this.txFunction = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tính năng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(910, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại nhiên liệu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhà sản xuất: ";
            // 
            // txNsx
            // 
            this.txNsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNsx.Location = new System.Drawing.Point(914, 201);
            this.txNsx.Multiline = true;
            this.txNsx.Name = "txNsx";
            this.txNsx.Size = new System.Drawing.Size(460, 40);
            this.txNsx.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại xe: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(641, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(217, 35);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtCar
            // 
            this.dtCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtCar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCar.Location = new System.Drawing.Point(45, 95);
            this.dtCar.Name = "dtCar";
            this.dtCar.ReadOnly = true;
            this.dtCar.RowHeadersWidth = 62;
            this.dtCar.RowTemplate.Height = 28;
            this.dtCar.Size = new System.Drawing.Size(813, 636);
            this.dtCar.TabIndex = 14;
            this.dtCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCar_CellContentClick);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(45, 33);
            this.txSearch.Multiline = true;
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(590, 30);
            this.txSearch.TabIndex = 15;
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(905, 645);
            this.txID.Multiline = true;
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(106, 40);
            this.txID.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1060, 691);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 40);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1218, 691);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 40);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(901, 691);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 40);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(910, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giá thuê: ";
            // 
            // txPrice
            // 
            this.txPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.Location = new System.Drawing.Point(914, 491);
            this.txPrice.Multiline = true;
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(460, 40);
            this.txPrice.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hãng: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txBrand
            // 
            this.txBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBrand.Location = new System.Drawing.Point(914, 586);
            this.txBrand.Multiline = true;
            this.txBrand.Name = "txBrand";
            this.txBrand.Size = new System.Drawing.Size(460, 40);
            this.txBrand.TabIndex = 31;
            this.txBrand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txFuel
            // 
            this.txFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFuel.FormattingEnabled = true;
            this.txFuel.Items.AddRange(new object[] {
            "Xăng",
            "Dầu ",
            "Điện ",
            "Khác"});
            this.txFuel.Location = new System.Drawing.Point(914, 300);
            this.txFuel.Name = "txFuel";
            this.txFuel.Size = new System.Drawing.Size(460, 37);
            this.txFuel.TabIndex = 33;
            // 
            // txModel
            // 
            this.txModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txModel.FormattingEnabled = true;
            this.txModel.Items.AddRange(new object[] {
            "4 chỗ (Mini)",
            "4 chỗ (Sedan)",
            "4 chỗ (Hatchback)",
            "5 chỗ (CUV Gầm cao)",
            "7 chỗ (SUV Gầm cao)",
            "7 chỗ (MPV Gầm thấp)",
            "Bán tải"});
            this.txModel.Location = new System.Drawing.Point(914, 101);
            this.txModel.Name = "txModel";
            this.txModel.Size = new System.Drawing.Size(460, 37);
            this.txModel.TabIndex = 34;
            // 
            // txFunction
            // 
            this.txFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFunction.Location = new System.Drawing.Point(914, 391);
            this.txFunction.Multiline = true;
            this.txFunction.Name = "txFunction";
            this.txFunction.Size = new System.Drawing.Size(460, 40);
            this.txFunction.TabIndex = 23;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(669, 752);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(189, 86);
            this.btnExport.TabIndex = 35;
            this.btnExport.Text = "Xuất file Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Brown;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Location = new System.Drawing.Point(462, 752);
            this.btnImport.Name = "btnImport";
            this.btnImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImport.Size = new System.Drawing.Size(189, 86);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "Nhập file Excel";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1421, 850);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txModel);
            this.Controls.Add(this.txFuel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBrand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txFunction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNsx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.dtCar);
            this.Name = "FormCar";
            this.Text = "FormCar";
            this.Load += new System.EventHandler(this.FormCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNsx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtCar;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBrand;
        private System.Windows.Forms.ComboBox txFuel;
        private System.Windows.Forms.ComboBox txModel;
        private System.Windows.Forms.TextBox txFunction;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}