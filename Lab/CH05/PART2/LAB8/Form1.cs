using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal sales = Convert.ToDecimal((saleBox.Text));

        private void danielleBtn_Click(object sender, EventArgs e)
        {
            decimal daniSales = 0;
            decimal daniTotal = daniSales + sales;
            daniSalesBox.Text = String.Format("{0:C}", daniSales);
        }

        private void edwardBtn_Click(object sender, EventArgs e)
        {
            decimal edSales = 0; 
            decimal edTotal = edSales + sales;
            edSalesBox.Text = String.Format("{0:C}", edSales);
        }

        private void francisBtn_Click(object sender, EventArgs e)
        {
            decimal frankSales = 0;
            decimal frankTotal = frankSales + sales;
            frankSalesBox.Text = String.Format("{0:C}", frankSales);
        }
    }
}
