using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zipCodeInput_Click(object sender, EventArgs e)
        {
            int zipCodeInput = Convert.ToInt32(zipCodeBox.Text);
            int[] zipCodes = new int[10];
            {
                zipCodes[0] = 63101;
                zipCodes[1] = 63103;
                zipCodes[2] = 63105;
                zipCodes[3] = 63109;
                zipCodes[4] = 63113;
                zipCodes[5] = 63118;
                zipCodes[6] = 63130;
                zipCodes[7] = 63133;
                zipCodes[8] = 63136;
                zipCodes[9] = 63137;
            }

            decimal[] deliveryFee = new decimal[10];
            {
                deliveryFee[0] = 20m;
                deliveryFee[1] = 12m;
                deliveryFee[2] = 25m;
                deliveryFee[3] = 15m;
                deliveryFee[4] = 10m;
                deliveryFee[5] = 23m;
                deliveryFee[6] = 18m;
                deliveryFee[7] = 20m;
                deliveryFee[8] = 17m;
                deliveryFee[9] = 12m;
            }
            for (int i = 0; i < zipCodes.Length; i++)
            { 
                if (zipCodes[i] == zipCodeInput)
                { 
                    lblDeliveryCharges.Text = String.Format("{0:C}", deliveryFee[i]);
                    lblErrorOutput.Text = "";
                    break;
                }
                else
                { 
                    lblDeliveryCharges.Text = "";
                    lblErrorOutput.Text = String.Format("Please enter a valid Zip Code!");
                }
            }
        }
    }
}
