using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;

namespace DAL
{
    public class SqlConnectionData 
    {
        public SqlConnection Connect()
        {
            string StrCon = @"Data Source=LAPTOP-5LSNRIE9\KIEUHUYNH;Initial Catalog=QLXeDemo;Integrated Security=True";
            SqlConnection conn = new SqlConnection(StrCon);
            return conn;
        }
    }
    public class DataAccessLayer
    {
        private readonly SqlConnectionData _connectionData;
        public DataAccessLayer()
        {
            _connectionData = new SqlConnectionData();
        }
        public DataTable GetUser(string username, string password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = _connectionData.Connect())
            {
                string query = "SELECT UserRole FROM tbUser WHERE UserName = @username and UserPassword= @password ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }

    }
}
