using System;

namespace GUI.Forms
{
    partial class chart3
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
            this.dtDate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(28, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(695, 412);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "cartesianChart1";
            // 
            // dtDate
            // 
            this.dtDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDate.Location = new System.Drawing.Point(52, 477);
            this.dtDate.Name = "dtDate";
            this.dtDate.RowHeadersWidth = 62;
            this.dtDate.RowTemplate.Height = 28;
            this.dtDate.Size = new System.Drawing.Size(240, 150);
            this.dtDate.TabIndex = 1;
            // 
            // chart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 674);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.chart1);
            this.Name = "chart3";
            this.Load += new System.EventHandler(this.chart3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            this.ResumeLayout(false);

        }

        private void chart3_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1;
        private System.Windows.Forms.DataGridView dtDate;
    }
}