using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp_conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
             double tempF = Convert.ToDouble(txtTempF.Text);

                double tempC = (tempF - 32) * 5 / 9;

                txtTempC.Text = String.Format("{0:N4}", tempC);
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double tempC = Convert.ToDouble(txtTempC.Text);

            double tempF = (tempC * 9) / 5 + 32;

            txtTempF.Text = String.Format("{0:N4}", tempF);
        }
    }
    
   
    
}
