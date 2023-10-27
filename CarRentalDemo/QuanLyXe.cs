using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDemo
{
    public partial class QuanLyXe : MetroFramework.Forms.MetroForm
    {
        string StringConnect = @"Data Source=LAPTOP-5LSNRIE9\KIEUHUYNH;Initial Catalog=QLXeDemo;Integrated Security=True";

        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-5LSNRIE9\KIEUHUYNH;Initial Catalog=QLXeDemo;Integrated Security=True");
        private decimal rentPrice;

        private void OpenConnect()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

        }
        private void CloseConnect()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

        }
        private Boolean Exe(String cmd) 
        { 
            OpenConnect();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, cn);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch 
            {
                check = false;
            }
            CloseConnect(); ;
            return check;
        }
        private DataTable ReadQ(string cmd) 
        {
            OpenConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, cn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            CloseConnect();
            return dt;
        }

        private void load()
        { 
            DataTable dt = ReadQ("select * from tbCar");
            if (dt != null) 
            {
                GridViewCar.DataSource = dt;
            }
        }


        public QuanLyXe()
        {
            InitializeComponent();
            load();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void UserPass_Click(object sender, EventArgs e)
        {

        }

        private void passw_Click(object sender, EventArgs e)
        {

        }

        private void userLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txModel.Text = GridViewCar.CurrentRow.Cells[1].Value.ToString();
            txFactory.Text = GridViewCar.CurrentRow.Cells[2].Value.ToString();
            txFuel.Text = GridViewCar.CurrentRow.Cells[3].Value.ToString();
            txFunction.Text = GridViewCar.CurrentRow.Cells[4].Value.ToString();
            txCost.Text = GridViewCar.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txModel.ResetText();
            txFactory.ResetText();
            txFuel.ResetText();
            txCost.ResetText();
            txFunction.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Exe("insert into tbCar (Model, Manufacturer, FuelType, AvailableFeatures, RentPricePerDay) " +
            //"values (N'"+txModel.Text+"', N'"+txFactory.Text+"', N'"+txFuel.Text +"', N'"+txFunction.Text+"'," + Convert.ToDecimal(txCost.Text) + "')");
            using (SqlConnection connection = new SqlConnection(StringConnect))
            {
                // Mở kết nối
                connection.Open();

                // Tạo và thực thi câu lệnh SQL sử dụng tham số
                string query = "INSERT INTO tbCar (Model, Manufacturer, FuelType, AvailableFeatures, RentPricePerDay) VALUES (@Model, @Manufacturer, @FuelType, @AvailableFeatures, @RentPricePerDay)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model", txModel.Text);
                command.Parameters.AddWithValue("@Manufacturer", txFactory.Text);
                command.Parameters.AddWithValue("@FuelType", txFuel.Text);
                command.Parameters.AddWithValue("@AvailableFeatures", txFunction.Text);
                if (decimal.TryParse(txCost.Text, out rentPrice))
                {
                    string formattedRentPrice = rentPrice.ToString("0.00");
                    command.Parameters.AddWithValue("@RentPricePerDay", formattedRentPrice);
                }
                else
                {
                    MessageBox.Show("Giá thuê không hợp lệ. Vui lòng nhập số hợp lệ.");
                }
                //command.Parameters.AddWithValue("@RentPricePerDay", Convert.ToDecimal(txCost.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm xe thành công");
            }
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
