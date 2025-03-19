using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;


namespace GUI.Forms
{
    public partial class FormCar : Form
    {
        private readonly CarBus _bll;
        public FormCar()
        {
            InitializeComponent();
            txID.Visible = false;
            _bll = new CarBus();
            RefreshData();
        }
        private void RefreshData()
        {
            dtCar.DataSource = _bll.GetAllCar();
        }


        private void dtCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txID.Text = dtCar.CurrentRow.Cells[0].Value.ToString();
            txModel.Text = dtCar.CurrentRow.Cells[1].Value.ToString();
            txNsx.Text = dtCar.CurrentRow.Cells[2].Value.ToString();
            txFuel.Text = dtCar.CurrentRow.Cells[3].Value.ToString();
            txFunction.Text = dtCar.CurrentRow.Cells[4].Value.ToString();
            txPrice.Text = dtCar.CurrentRow.Cells[5].Value.ToString();
            txBrand.Text = dtCar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string model = txModel.Text;
            string nsx = txNsx.Text;
            string fuel = txFuel.Text;
            string func = txFunction.Text;
            double price = Convert.ToDouble(txPrice.Text);
            string brand = txBrand.Text;
            _bll.AddCar(model, nsx, fuel, func, price, brand);
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txID.Text);
            string model = txModel.Text;
            string nsx = txNsx.Text;
            string fuel = txFuel.Text;
            string func = txFunction.Text;
            double price = Convert.ToDouble(txPrice.Text);
            string brand = txBrand.Text;
            _bll.UpdateCar(id, model, nsx, fuel, func, price, brand);
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txID.Text);
            _bll.DeleteCar(id);
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txSearch.Text;
            dtCar.DataSource = _bll.SearchCar(keyword);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            _bll.ExportToExcel();
            MessageBox.Show("Create file success");

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string path = "D:\\Car_List.xlsx";
            dtCar.DataSource = _bll.ImportToExcel(path);
            MessageBox.Show("Import file success");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCar_Load(object sender, EventArgs e)
        {

        }

        private void txFuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
