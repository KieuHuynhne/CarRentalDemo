namespace GUI.Forms
{
    partial class chart2
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
            this.chart1 = new LiveCharts.WinForms.CartesianChart();
            this.dtBrand = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(25, 22);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1013, 620);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "cartesianChart1";
            // 
            // dtBrand
            // 
            this.dtBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBrand.Location = new System.Drawing.Point(1193, 51);
            this.dtBrand.Name = "dtBrand";
            this.dtBrand.RowHeadersWidth = 62;
            this.dtBrand.RowTemplate.Height = 28;
            this.dtBrand.Size = new System.Drawing.Size(88, 72);
            this.dtBrand.TabIndex = 1;
            // 
            // chart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 783);
            this.Controls.Add(this.dtBrand);
            this.Controls.Add(this.chart1);
            this.Name = "chart2";
            this.Text = "chart2";
            this.Load += new System.EventHandler(this.chart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1;
        private System.Windows.Forms.DataGridView dtBrand;
    }
}