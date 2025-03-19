using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUI.Forms;

namespace GUI
{
    public partial class FormReport : Form
    {
        private readonly OrderBus _bll;
        public FormReport()
        {
            InitializeComponent();
            _bll = new OrderBus();
            RefreshData();
        }
        private void RefreshData() 
        {
            int num = 0, car = _bll.getNumCar(), rent = _bll.getNumCarRent();
            num = car - rent;
            dtModel.DataSource = _bll.GetReportModel();
            dtBrand.DataSource = _bll.GetReportBrand();
            dtDate.DataSource = _bll.GetReportDate();
            NumberSum.Text = car.ToString();
            NumberRent.Text = rent.ToString();
            NumberEmpty.Text = num.ToString(); 
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtModel_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart a = new Chart();
            a.ShowDialog();
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            chart2 a = new chart2();
            a.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            chart3 a = new chart3();
            a.ShowDialog();
        }
    }
}
