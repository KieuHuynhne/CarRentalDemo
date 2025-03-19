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

using OfficeOpenXml.Style;
using System.Windows.Input;

namespace DAL
{
    public class CarDAL
    {
        private readonly SqlConnectionData _connectionData;

        public CarDAL()
        {
            _connectionData = new SqlConnectionData();
        }

        public void AddCar(string model, string nsx, string fuel, string func, double price, string brand)
        {
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "INSERT INTO tbCar (Model, Manufacturer, FuelType, AvailableFeatures, RentPricePerDay, Brand, Status) VALUES (@model,@nsx,@fuel,@func,@price,@brand,N'Trống')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@nsx", nsx);
                cmd.Parameters.AddWithValue("@fuel", fuel);
                cmd.Parameters.AddWithValue("@func", func);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@brand", brand);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCar(int id)
        {
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "DELETE FROM tbCar WHERE CarID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable GetAllCar()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCar;";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public DataTable SearchCar(string keyword)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCar WHERE Model LIKE @keyword OR Manufacturer LIKE @keyword OR Brand LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public DataTable GetCarsForRent(string model, string function, string fueltype)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCar WHERE Model LIKE @model OR AvailableFeatures LIKE @function OR FuelType LIKE @fueltype";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@model", "N'%" + model + "%'");
                cmd.Parameters.AddWithValue("@function", "N'%" + function + "%'");
                cmd.Parameters.AddWithValue("@fueltype", "N'%" + fueltype + "%'");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public void UpdateCar(int id, string model, string nsx, string fuel, string func, double price, string brand)
        {
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "UPDATE tbCar SET Model = @model, Manufacturer =@nsx, FuelType = @fuel,AvailableFeatures=@func, RentPricePerDay=@price, Brand=@brand WHERE CarID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@nsx", nsx);
                cmd.Parameters.AddWithValue("@fuel", fuel);
                cmd.Parameters.AddWithValue("@func", func);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@brand", brand);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ExportToExcel() 
        {
            DataTable cars = GetAllCar();
            ExcelPackage excel = new ExcelPackage();
            // name of the sheet
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
            // setting the properties
            // of the work sheet
            workSheet.DefaultRowHeight = 12;
            // Header of the Excel sheet
            workSheet.Cells[1, 1].Value = "No.";
            workSheet.Cells[1, 2].Value = "Model";
            workSheet.Cells[1, 3].Value = "Manufactory";
            workSheet.Cells[1, 4].Value = "Fuel";
            workSheet.Cells[1, 5].Value = "Feature";
            workSheet.Cells[1, 6].Value = "Price";
            workSheet.Cells[1, 7].Value = "Brand";

            int recordIndex = 2;
            // Setting the properties
            // of the first row
            workSheet.Row(1).Height = 25;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            foreach (DataRow car in cars.Rows) // Sửa lỗi, duyệt qua các dòng của DataTable
            {
                workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                workSheet.Cells[recordIndex, 2].Value = car["Model"].ToString();
                workSheet.Cells[recordIndex, 3].Value = car["Manufacturer"].ToString();
                workSheet.Cells[recordIndex, 4].Value = car["FuelType"].ToString();
                workSheet.Cells[recordIndex, 5].Value = car["AvailableFeatures"].ToString();
                workSheet.Cells[recordIndex, 6].Value = car["RentPricePerDay"].ToString();
                workSheet.Cells[recordIndex, 7].Value = car["Brand"].ToString();
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
            workSheet.Column(6).AutoFit();
            workSheet.Column(7).AutoFit();

            // file name with .xlsx extension
            string p_strPath = "D:\\Car_List.xlsx";
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

        public object ImportToExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path))) 
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dt = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++) 
                {
                    dt.Columns.Add(excelWorksheet.Cells[1,i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<String> listRow = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRow.Add(excelWorksheet.Cells[i,j].Value.ToString());
                    }
                    dt.Rows.Add(listRow.ToArray());
                }
                return dt;
            }
        }

        public DataTable SearchCarByID(int id)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT * FROM tbCar WHERE CarID = @Keyword";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", id);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }

        public void UpdateStatus(int id, string status)
        {
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "UPDATE tbCar SET Status = @status WHERE CarID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
