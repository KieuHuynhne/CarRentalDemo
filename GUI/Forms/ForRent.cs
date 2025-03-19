using BLL;
using DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
using System.Windows.Media;


namespace GUI.Forms
{
    public partial class ForRent : Form
    {
     
        private readonly CarBus _bll;
        public ForRent()
        {
            InitializeComponent();
            _bll = new CarBus();
            RefreshData();
        }

        //Methods
      

        private void ForRent_Load(object sender, EventArgs e)
        {

        }

        //Display data Car
       
   
        private void RefreshData()
        {
            dtCarRent.DataSource = _bll.GetAllCar();
        }

        private void dtCarRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCarType_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);

        }


        private void cbFunction(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string model = GetSelectedTextFromGroupBox(gbModel);
            string function = GetSelectedTextFromGroupBox(gbFunc);
            string fueltype = GetSelectedTextFromGroupBox(gbFuel);
            dtCarRent.DataSource = _bll.GetCarsForRent(model,function,fueltype);
            tbDemo.Text = model.ToString();
        }


        private string GetSelectedTextFromGroupBox(System.Windows.Forms.GroupBox groupBox)
        {
            foreach (System.Windows.Forms.Control control in groupBox.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    return checkBox.Text;
                }
                else if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return string.Empty;
        }

        private void tbDemo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
