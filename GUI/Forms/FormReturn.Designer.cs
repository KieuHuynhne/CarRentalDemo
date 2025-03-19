namespace GUI.Forms
{
    partial class FormReturn
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
            this.dtOrder = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txIDCar = new System.Windows.Forms.TextBox();
            this.txTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOrder
            // 
            this.dtOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtOrder.Location = new System.Drawing.Point(28, 25);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.ReadOnly = true;
            this.dtOrder.RowHeadersWidth = 62;
            this.dtOrder.RowTemplate.Height = 28;
            this.dtOrder.Size = new System.Drawing.Size(613, 378);
            this.dtOrder.TabIndex = 16;
            this.dtOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtOrder_CellContentClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(457, 425);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(184, 46);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Trả xe";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txOrderID
            // 
            this.txOrderID.Location = new System.Drawing.Point(105, 425);
            this.txOrderID.Multiline = true;
            this.txOrderID.Name = "txOrderID";
            this.txOrderID.Size = new System.Drawing.Size(328, 46);
            this.txOrderID.TabIndex = 18;
            this.txOrderID.TextChanged += new System.EventHandler(this.txOrderID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã đơn";
            // 
            // txIDCar
            // 
            this.txIDCar.Location = new System.Drawing.Point(661, 425);
            this.txIDCar.Multiline = true;
            this.txIDCar.Name = "txIDCar";
            this.txIDCar.Size = new System.Drawing.Size(111, 46);
            this.txIDCar.TabIndex = 20;
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(661, 481);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(111, 46);
            this.txTotal.TabIndex = 21;
            // 
            // FormReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 539);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.txIDCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txOrderID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtOrder);
            this.Name = "FormReturn";
            this.Text = "FormReturn";
            ((System.ComponentModel.ISupportInitialize)(this.dtOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIDCar;
        private System.Windows.Forms.TextBox txTotal;
    }
}