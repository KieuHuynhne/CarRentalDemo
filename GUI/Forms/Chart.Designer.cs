namespace GUI.Forms
{
    partial class Chart
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
            this.dtModel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtModel)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(39, 25);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(776, 478);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "cartesianChart2";
            // 
            // dtModel
            // 
            this.dtModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtModel.Location = new System.Drawing.Point(74, 522);
            this.dtModel.Name = "dtModel";
            this.dtModel.RowHeadersWidth = 62;
            this.dtModel.RowTemplate.Height = 28;
            this.dtModel.Size = new System.Drawing.Size(137, 93);
            this.dtModel.TabIndex = 2;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 627);
            this.Controls.Add(this.dtModel);
            this.Controls.Add(this.chart1);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1;
        private System.Windows.Forms.DataGridView dtModel;
    }
}