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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Definitions.Charts;


namespace GUI.Forms
{
    public partial class chart2 : Form
    {
        private readonly OrderBus _bll;
        public chart2()
        {
            InitializeComponent();
            _bll = new OrderBus();
            dtBrand.Visible = false;
            RefreshData();
        }

        private void RefreshData()
        {
            dtBrand.DataSource = _bll.GetReportBrand();
            InitializeChart();
        }
        private void InitializeChart()
        {
            chart1.Series.Clear();
            // Tạo dữ liệu mẫu từ DataGridView (thay bằng dữ liệu thực của bạn)
            var carTypes = new List<string>();
            var revenueByType = new List<double>();

            foreach (DataGridViewRow row in dtBrand.Rows)
            {
                var modelCell = row.Cells["Brand"];
                var totalRevenueCell = row.Cells["TotalRevenue"];

                if (modelCell.Value != null && totalRevenueCell.Value != null)
                {
                    carTypes.Add(modelCell.Value.ToString());
                    revenueByType.Add(Convert.ToDouble(totalRevenueCell.Value));
                }
                // Tạo series và thêm dữ liệu
                var revenueSeries = new ColumnSeries
                {
                    Title = "Doanh thu theo hãng xe",
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

            
        }

        private void chart2_Load(object sender, EventArgs e)
        {

        }
    }
}
