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
    public partial class DetailOrder : Form
    {
        private readonly CarBus _bllCar;
        private readonly CustomerBus _bllCus;
        private readonly OrderBus _bllOrder;
        public DetailOrder()
        {
            InitializeComponent();
            _bllCar = new CarBus();
            _bllCus = new CustomerBus();
            _bllOrder = new OrderBus();
            txIDCus.Visible = false;
            RefreshData();
        }
        private void RefreshData()
        {
            dtOrder.DataSource = _bllOrder.GetAllOder();
        }


        private void txOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DisplayCus();
            DisplayCar();
            DisplayRent();
            RefreshData();
        }

        private void dtOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txOrderID.Text = dtOrder.CurrentRow.Cells[0].Value.ToString();
            txIDCar.Text = dtOrder.CurrentRow.Cells[2].Value.ToString();
            txIDCus.Text = dtOrder.CurrentRow.Cells[1].Value.ToString();
        }

        private void DisplayCus() 
        {
            int id;

            if (int.TryParse(txIDCus.Text, out id))
            {
                DataTable dt = new DataTable();
                dt = (DataTable)_bllCus.SearchCustommersByID(id);
                DataRow row = dt.Rows[0];
                txEmail.Text = row["Email"].ToString();
                txName.Text = row["CustomerName"].ToString();
                txAdd.Text = row["CustomerAddress"].ToString();
                txPhone.Text = row["Phone"].ToString();
            }
            else
            {
                MessageBox.Show("Mã đơn hàng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCar() 
        {
            int id;

            if (int.TryParse(txIDCar.Text, out id))
            {
                DataTable dt = new DataTable();
                dt = (DataTable)_bllCar.SearchCarsByID(id);
                DataRow row = dt.Rows[0];
                txIDCar.Text = row["CarID"].ToString();
                txModel.Text = row["Model"].ToString();
                txBrand.Text = row["Brand"].ToString();
                txPrice.Text = row["RentPricePerDay"].ToString();
                txNsx.Text = row["Manufacturer"].ToString();
                txFuel.Text = row["FuelType"].ToString();
                txFunction.Text = row["AvailableFeatures"].ToString();
                txStatus.Text = row["Status"].ToString();
            }
            else
            {
                MessageBox.Show("Mã đơn hàng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRent() 
        {
            txDayStart.Text = dtOrder.CurrentRow.Cells[3].Value.ToString();
            txDayEnd.Text = dtOrder.CurrentRow.Cells[4].Value.ToString();
            txTotal.Text = dtOrder.CurrentRow.Cells[5].Value.ToString();
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
