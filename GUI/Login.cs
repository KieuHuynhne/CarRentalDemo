using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Login : Form
    {
        UserDTO user = new UserDTO();
        private readonly UserBus _userbll;
        public Login()
        {
            InitializeComponent();
            _userbll = new UserBus();
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txUser.Text;
            string password = txPass.Text;

            UserDTO user = new UserDTO
            {
                Username = username,
                UserPassword = password
            };

            string role = _userbll.ValidateLogin(username, password);
            if (role == "admin")
            {
                MessageBox.Show("Admin đăng nhập thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                using (AdminForm a = new AdminForm()) 
                {
                    a.ShowDialog();
                }
               
            }
            else if (role == "staff")
            {
                MessageBox.Show("Nhân viên đăng nhập thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StaffForm a = new StaffForm())
                {
                    a.ShowDialog();
                }
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            } 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            txPass.PasswordChar = '*';
        }

        private void txUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
