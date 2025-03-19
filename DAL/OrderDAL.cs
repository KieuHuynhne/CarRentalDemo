using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OfficeOpenXml;
using System.IO;
using DTO;
using System.Windows.Media.Animation;

namespace DAL
{
    public class OrderDAL
    {
        private readonly SqlConnectionData _connectionData;
        public OrderDAL()
        {
            _connectionData = new SqlConnectionData();
        }

        public void AddOrder(int cusID, string carID, string dtStart, string dtEnd, string total)
        {

            int CarID = int.Parse(carID);
            DateTime DTStart = DateTime.Parse(dtStart);
            DateTime DTEnd = DateTime.Parse(dtEnd);
            double Total = Convert.ToDouble(total);
            if (cusID != -1)
            {
                using (SqlConnection con = _connectionData.Connect())
                {
                    string query = "INSERT INTO tbOrder (CustomerID, CarID, RentStartDate, RentEndDate, TotalCost) VALUES (@IDCus, @CarID, @dtStart, @dtEnd, @total)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IDCus", cusID);
                    cmd.Parameters.AddWithValue("@CarID", CarID);
                    cmd.Parameters.AddWithValue("@dtStart", DTStart);
                    cmd.Parameters.AddWithValue("@dtEnd", DTEnd);
                    cmd.Parameters.AddWithValue("@total", Total);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            else { }
                
            
        }

        public DataTable GetAllOder()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbOrder";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public int getIDCus(string phone) 
        {
            int cusID = -1;
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "Select CustomerID from tbCustomer where Phone like @phone";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@phone", '%' +phone+'%');
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Nếu có giá trị trả về, chuyển đổi sang kiểu int
                    cusID = Convert.ToInt32(result);
                }

                con.Close();
            }
            return cusID;
        }

        public DataTable GetOrderRent()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbOrder o JOIN tbCar c ON o.CarID = c.CarID WHERE c.Status=N'Đang cho thuê'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public DataTable GetReportBrand()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "Select * from fn_thongke_brand()";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public DataTable GetReportModel()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "Select * from fn_thongke_model()";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public DataTable GetReportDate()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "Select * from fn_thongke_date()";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public int getNumCar()
        {
            int num = 0;
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT COUNT(CarID) AS TotalCars FROM tbCar;";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                num = (int)result;
                con.Close();
            }
            return num;
        }

        public int getNumCarRent()
        {
            int num = 0;
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT COUNT(CarID) AS TotalCarsRenting FROM tbCar WHERE Status = 'Đang cho thuê'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                num = (int)result;
                con.Close();
            }
            return num;
        }
    }
}
