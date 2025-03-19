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
    public partial class FormReturn : Form
    {
        private readonly CarBus _bllCar;
        private readonly CustomerBus _bllCus;
        private readonly OrderBus _bllOrder;
        public FormReturn()
        {
            InitializeComponent();
            _bllCar = new CarBus();
            _bllCus = new CustomerBus();
            _bllOrder = new OrderBus();
            txIDCar.Visible = false;
            txTotal.Visible = false;
            RefreshData();
        }
       
        private void RefreshData()
        {
            dtOrder.DataSource = _bllOrder.GetOrderRent();
        }

        private void dtOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txOrderID.Text = dtOrder.CurrentRow.Cells[0].Value.ToString();
            txIDCar.Text = dtOrder.CurrentRow.Cells[2].Value.ToString();
            txTotal.Text = dtOrder.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txIDCar.Text);
            string status = "Trống";
            _bllCar.UpdateStatus(id, status);
            string totalCost = txTotal.Text.ToString();
            string message = $"Số tiền cần thanh toán: {totalCost + "$"}";
            DialogResult result = MessageBox.Show(message, "Xác nhận trả xe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Trả xe thành công. Hẹn gặp lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Vui lòng thanh toán!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string status1 = "Đang cho thuê";
                _bllCar.UpdateStatus(id, status1);
            }
            RefreshData();
        }

        private void txOrderID_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
