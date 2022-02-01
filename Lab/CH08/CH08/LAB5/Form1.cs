using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal totalCost;
            int numNights = Convert.ToInt32(nightsBox.Text);

            decimal[] nightlyRate = new decimal[4];
            {
                nightlyRate[0] = 200;
                nightlyRate[1] = 180;
                nightlyRate[2] = 160;
                nightlyRate[3] = 145;
            }
            for (int i = 0; i < nightlyRate.Length; i++)
            {
                if (numNights < 3)
                {
                    lblNightlyRate.Text = String.Format("{0:C}", nightlyRate[0]);
                    lblTotalCost.Text = String.Format("{0:C}", numNights * nightlyRate[0]);
                    break;
                }

                else if (numNights < 5)
                {
                    lblNightlyRate.Text = String.Format("{0:C}", nightlyRate[1]);
                    lblTotalCost.Text = String.Format("{0:C}", numNights * nightlyRate[1]);
                    break;
                }
                else if (numNights < 8)
                {
                    lblNightlyRate.Text = String.Format("{0:C}", nightlyRate[2]);
                    lblTotalCost.Text = String.Format("{0:C}", numNights * nightlyRate[2]);
                    break;
                }
                else
                {
                    lblNightlyRate.Text = String.Format("{0:C}", nightlyRate[3]);
                    lblTotalCost.Text = String.Format("{0:C}", numNights * nightlyRate[3]);
                    break;
                }
            }
        }
    }
}
