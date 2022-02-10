using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            CalculateTotalArea();

            CalculatePaintEstimate();
        }

        private void CalculateTotalArea()
        {
            decimal length = Convert.ToDecimal(lengthBox.Text);
            decimal width = Convert.ToDecimal(widthBox.Text);
            decimal height = Convert.ToDecimal(heightBox.Text);

            lblAreaOutput.Text = String.Format("{0}", (length * width) + (width * height) * 2 + (length * height) * 2);
        }

        private void CalculatePaintEstimate()
        {
            decimal surfaceArea = Convert.ToDecimal(lblAreaOutput.Text);
            decimal rate = 6;

            lblTotalCost.Text = String.Format("{0:C}", surfaceArea * rate);
        }
    }
}
