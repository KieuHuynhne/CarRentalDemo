using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using BLL;
using LiveCharts.Definitions.Charts;

namespace GUI.Forms
{
    public partial class chart3 : Form
    {
        private readonly OrderBus _bll;
        public chart3()
        {
            InitializeComponent();
            _bll = new OrderBus();
            RefreshData();
            dtDate.Visible = false;

        }

        private void RefreshData()
        {
            dtDate.DataSource = _bll.GetReportDate();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            // Tạo dữ liệu mẫu từ DataGridView (thay bằng dữ liệu thực của bạn)
            var carTypes = new List<string>();
            var revenueByType = new List<double>();

            foreach (DataGridViewRow row in dtDate.Rows)
            {
                var modelCell = row.Cells["RentDate"];
                var totalRevenueCell = row.Cells["TotalRevenue"];

                if (modelCell.Value != null && totalRevenueCell.Value != null)
                {
                    carTypes.Add(modelCell.Value.ToString());
                    revenueByType.Add(Convert.ToDouble(totalRevenueCell.Value));
                }
            }

            // Tạo series và thêm dữ liệu
            var revenueSeries = new ColumnSeries
            {
                Title = "Doanh thu theo ngày",
                Values = new ChartValues<double>(revenueByType)
            };

            // Thêm series vào biểu đồ
            chart1.Series.Add(revenueSeries);

            // Đặt một số thuộc tính khác của biểu đồ nếu cần
            chart1.AxisX.Add(new Axis
            {
                Labels = carTypes // Sử dụng tên loại xe làm nhãn trục X
            });

            chart1.AxisY.Add(new Axis
            {
                Title = "Doanh thu $",
                LabelFormatter = value => value.ToString() // Định dạng số liệu trên trục Y
            });
        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void chart3_Load_1(object sender, EventArgs e)
        {

            
        }
    }
}
