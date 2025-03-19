using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class FormOrder : Form
    {
        private readonly CarBus _bllCar;
        private readonly CustomerBus _bllCus;
        private readonly OrderBus _bllOrder;
        public FormOrder()
        {
            InitializeComponent();
            _bllCar = new CarBus();
            _bllCus = new CustomerBus();
            _bllOrder = new OrderBus();
            txIDCus.Visible = false;
            textBox1.Visible = false;
            btnLoad.Visible = false;
            dtCus.Visible = false;
            RefreshData();
        }
        private void RefreshData()
        {
            dtCar.DataSource = _bllCar.GetAllCar();
            dtCus.DataSource = _bllCus.GetAllCustomers();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = cbModel.Text;
            dtCar.DataSource = _bllCar.SearchCar(keyword);
        }

        private void dtCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txIDCar.Text = dtCar.CurrentRow.Cells[0].Value.ToString();
            txPrice.Text = dtCar.CurrentRow.Cells[5].Value.ToString();
            txPrice.ReadOnly = true;

        }

        private void CalDay()
        {
            DateTime dateTimeStart = datetimeStart.Value;
            DateTime dateTimeEnd = datetimeEnd.Value;

            TimeSpan timeSpan = dateTimeEnd - dateTimeStart;

            int numberDay = (int)timeSpan.TotalDays;

            txTotal.Text = CalTotalPrice(numberDay).ToString();


        }

        private double CalTotalPrice(int days)
        {
            if (double.TryParse(txPrice.Text, out double price))
            {
                double total = (days + 1) * price;

                return total;
            }
            else
            {
                return 0;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            ThemDon();

            MessageBox.Show("Thuê thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ThemDon()
        {
            string phone = txPhone.Text;
            string CarID = txIDCar.Text;
            string dtStart = datetimeStart.Text;
            string dtEnd = datetimeEnd.Text;
            string total = txTotal.Text;
            int check = _bllOrder.getIDCus(phone);
            txIDCus.Text = check.ToString();
            int cusID = Convert.ToInt32(txIDCus.Text);
            textBox1.Text = cusID.ToString();
            _bllOrder.AddOrder(cusID, CarID, dtStart, dtEnd, total);
            int id = int.Parse(txIDCar.Text);
            string status = "Đang cho thuê";
            _bllCar.UpdateStatus(id, status);
        }
        private void datetimeEnd_ValueChanged(object sender, EventArgs e)
        {
            CalDay();
        }
        private int getIDfromView()
        {
            int rowCount = dtCus.RowCount;
            int id = 0;

            if (rowCount > 0)
            {
                // Lấy dòng cuối cùng
                DataGridViewRow lastRow = dtCus.Rows[rowCount - 1];

                // Truy cập giá trị từ ô trong dòng cuối cùng
                object idCellValue = lastRow.Cells["CustomerID"].Value;

                // Kiểm tra giá trị của ô có tồn tại và không phải là null
                if (idCellValue != null)
                {
                    // Chuyển đổi giá trị ô thành kiểu int
                    id = Convert.ToInt32(idCellValue);
                }
            }

            return id;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txPhone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CustomerOldOrNew()
        {
            DataTable dt = new DataTable();
            string keyw = txPhone.Text;
            dt = (DataTable)_bllCus.SearchCustommers(keyw);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txEmail.Text = row["Email"].ToString();
                txName.Text = row["CustomerName"].ToString();
                txAdd.Text = row["CustomerAddress"].ToString();
                txIDCus.Text = row["CustomerID"].ToString();
                txName.ReadOnly = true;
                txAdd.ReadOnly = true;
                txEmail.ReadOnly = true;

            }
            else
            {
                DialogResult result = MessageBox.Show("Khách hàng mới. Thêm vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    string phoneNumber = txPhone.Text;

                    AddNewCus form = new AddNewCus(phoneNumber);
                    if (form.ShowDialog() == DialogResult.OK) // Đợi đến khi form AddNewCus đóng và kiểm tra kết quả
                    {
                        // Lấy thông tin khách hàng mới từ form AddNewCus
                        Customer newCustomer = form.NewCustomer;

                        // Hiển thị thông tin trên form chính
                        txEmail.Text = newCustomer.Email;
                        txName.Text = newCustomer.CustomerName;
                        txAdd.Text = newCustomer.CustomerAddress;
                        txName.ReadOnly = true;
                        txAdd.ReadOnly = true;
                        txEmail.ReadOnly = true;
                        RefreshCustomerData();
                    }

                } 
            }

        }

       

        private void txPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CustomerOldOrNew();
            }
        }

        private void txTotal_TextChanged(object sender, EventArgs e)
        {

        }
        public void RefreshCustomerData()
        {
            // Làm mới dữ liệu khách hàng từ database
            DataTable customerTable = _bllCus.GetAllCustomers(); // Thay thế bằng phương thức thích hợp của bạn

            if (customerTable.Rows.Count > 0)
            {
                // Lấy thông tin của khách hàng cuối cùng (có thể là khách hàng mới thêm vào)
                DataRow lastCustomer = customerTable.Rows[customerTable.Rows.Count - 1];

                // Hiển thị thông tin khách hàng trong TextBox
                txIDCus.Text = lastCustomer["CustomerID"].ToString();
                txName.Text = lastCustomer["CustomerName"].ToString();
                txAdd.Text = lastCustomer["CustomerAddress"].ToString();
                txEmail.Text = lastCustomer["Email"].ToString();
                txPhone.Text = lastCustomer["Phone"].ToString();

                // Các TextBox khác tương tự
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtCus.DataSource = _bllCus.GetAllCustomers();
        }
    }
}
