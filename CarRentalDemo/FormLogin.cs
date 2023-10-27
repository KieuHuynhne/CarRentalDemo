using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalDemo
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conectionString = @"Data Source=LAPTOP-5LSNRIE9\KIEUHUYNH;Initial Catalog=QLXeDemo;Integrated Security=True";
            SqlConnection cn = new SqlConnection(conectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbUser where Username = N'" + TxUserLogin.Text + "' and UserPassword = N'" + TxUserPass.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][3].ToString() == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền admin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AddCustomer a = new AddCustomer();
                    a.Show();
                }
                else if (dt.Rows[0][3].ToString() == "user")
                {
                    MessageBox.Show("Đăng nhập thành công! User", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AddCustomer a = new AddCustomer();
                    a.Show();
                }
               
            }
            else 
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
