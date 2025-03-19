using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class FormCustomer : Form
    {
        private readonly CustomerBus _bll;
        public FormCustomer()
        {
            InitializeComponent();
            txID.Visible = false;
            _bll = new CustomerBus();
            RefreshData();
        }

        private void RefreshData()
        {
            dtCustomer.DataSource= _bll.GetAllCustomers();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dtCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txID.Text = dtCustomer.CurrentRow.Cells[0].Value.ToString();
            txName.Text = dtCustomer.CurrentRow.Cells[1].Value.ToString();
            txAddress.Text = dtCustomer.CurrentRow.Cells[2].Value.ToString();
            txPhone.Text = dtCustomer.CurrentRow.Cells[3].Value.ToString();
            txEmail.Text = dtCustomer.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txName.Text;
            string address = txAddress.Text;
            string phone= txPhone.Text;
            string email = txEmail.Text;
            _bll.AddCustomer(name, address, phone, email);
            RefreshData();
            //MessageBox.Show("Thêm khách hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txID.Text);
            string name = txName.Text;
            string address = txAddress.Text;
            string phone = txPhone.Text;
            string email = txEmail.Text;
            _bll.UpdateCustomer(id, name, address, phone, email);
            RefreshData();
            //MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txID.Text);
            _bll.DeleteCustomer(id);
            RefreshData();
            //MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txSearch.Text;
            dtCustomer.DataSource = _bll.SearchCustommers(keyword);
        }

        private void txID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            _bll.ExportToExcel();
            MessageBox.Show("Create file success");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
