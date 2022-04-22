using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT7Retake
{
    public partial class HOT7Retake : Form
    {
        //private SalesFigures _stats;
        public HOT7Retake()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                float sales = (float)Convert.ToDecimal(txtFigures.Text);

                SalesFigures enteredSales = new SalesFigures.AddSales(sales);
                {
                    lblNumber.Text += ToString();
                    lblSum.Text += ToString();
                    lblAverage.Text += ToString();
                    lblLowest.Text += ToString();
                    lblHighest.Text += ToString();
                }

            }
            catch (ArgumentException)
            {
                lblErrorMsg.Visible = true;
            }

        }
        
    }
}
