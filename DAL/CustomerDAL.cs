using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;

namespace DAL
{
    public class CustomerDAL
    {
        private readonly SqlConnectionData _connectionData;
        public CustomerDAL()
        {
            _connectionData = new SqlConnectionData();
        }
        public DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCustomer";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public void AddCustomer(string name, string address, string phone, string email)
        {
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "INSERT INTO tbCustomer (CustomerName, CustomerAddress, Phone, Email) VALUES (@name,@address,@phone,@email)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateCustomer(int id, string name, string address, string phone, string email)
        {


            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "UPDATE tbCustomer SET CustomerName = @name, CustomerAddress =@address, Phone =@phone, Email=@email WHERE CustomerID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCustomer(int id)
        {

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "DELETE FROM tbCustomer WHERE CustomerID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchCustommers(string keyword)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCustomer WHERE CustomerName LIKE @keyword OR CustomerAddress LIKE @keyword OR CustomerAddress LIKE @keyword OR Phone LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public void ExportToExcel()
        {

            DataTable customer = GetAllCustomers();
            ExcelPackage excel = new ExcelPackage();
            // name of the sheet
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
            // setting the properties
            // of the work sheet
            workSheet.DefaultRowHeight = 12;
            // Header of the Excel sheet
            workSheet.Cells[1, 1].Value = "No.";
            workSheet.Cells[1, 2].Value = "Tên khách hàng";
            workSheet.Cells[1, 3].Value = "Địa chỉ";
            workSheet.Cells[1, 4].Value = "Số điện thoại";
            workSheet.Cells[1, 5].Value = "Email";

            int recordIndex = 2;
            // Setting the properties
            // of the first row
            workSheet.Row(1).Height = 25;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            foreach (DataRow p in customer.Rows) // Sửa lỗi, duyệt qua các dòng của DataTable
            {
                workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                workSheet.Cells[recordIndex, 2].Value = p["CustomerName"].ToString();
                workSheet.Cells[recordIndex, 3].Value = p["CustomerAddress"].ToString();
                workSheet.Cells[recordIndex, 4].Value = p["Phone"].ToString();
                workSheet.Cells[recordIndex, 5].Value = p["Email"].ToString();
                recordIndex++;
            }
            // By default, the column width is not
            // set to auto fit for the content
            // of the range, so we are using
            // AutoFit() method here.
            workSheet.Column(1).AutoFit();
            workSheet.Column(2).AutoFit();
            workSheet.Column(3).AutoFit();
            workSheet.Column(4).AutoFit();
            workSheet.Column(5).AutoFit();

            // file name with .xlsx extension
            string p_strPath = "D:\\Customer_List.xlsx";
            if (File.Exists(p_strPath))
                File.Delete(p_strPath);
            // Create excel file on physical disk
            FileStream objFileStrm = File.Create(p_strPath);
            objFileStrm.Close();
            // Write content to excel file
            File.WriteAllBytes(p_strPath, excel.GetAsByteArray());
            //Close Excel package
            excel.Dispose();
        }

        public DataTable SearchCustommersByID(int keyword)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCustomer WHERE CustomerID = @keyword ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@keyword",keyword);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }
    }
}
