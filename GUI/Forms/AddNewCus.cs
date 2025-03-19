using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Forms
{
    public partial class AddNewCus : Form
    {
        private readonly CustomerBus _bll;
        public Customer NewCustomer { get; private set; }
        public AddNewCus(string phoneNumber)
        {
            InitializeComponent();
            _bll = new CustomerBus();
            txPhone.Text = phoneNumber;
            txPhone.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txName.Text;
            string address = txAddress.Text;
            string phone = txPhone.Text;
            string email = txEmail.Text;
            _bll.AddCustomer(name, address, phone, email);

            Customer newCustomer = new Customer
            {
                CustomerName = name,
                CustomerAddress = address,
                Email = email,
                Phone = phone,
            };
            NewCustomer = newCustomer;
            this.Close();
        }

        private void AddNewCus_Load(object sender, EventArgs e)
        {

        }
    }
}
