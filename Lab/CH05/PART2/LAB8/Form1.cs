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
        decimal daniTotal = 0;
        decimal edTotal = 0;
        decimal frankTotal = 0;


        private void danielleBtn_Click(object sender, EventArgs e)
        {
            decimal individualSale = Convert.ToDecimal(saleBox.Text);

            daniTotal += individualSale;
            daniSalesBox.Text = String.Format("{0:C}", daniTotal);
            grandTotalBox.Text = String.Format("{0:C}", daniTotal + edTotal + frankTotal);

            if (daniTotal == edTotal && daniTotal == frankTotal)
                highSaleOutput.Text = String.Format("Everyone is doing a great job!");
            else if (daniTotal > edTotal && daniTotal > frankTotal)
                highSaleOutput.Text = String.Format("Danielle has the highest sales");
        }

        private void edwardBtn_Click(object sender, EventArgs e)
        {
            decimal individualSale = Convert.ToDecimal(saleBox.Text);

            edTotal += individualSale;
            edSalesBox.Text = String.Format("{0:C}", edTotal);
            grandTotalBox.Text = String.Format("{0:C}", daniTotal + edTotal + frankTotal);

            if (edTotal == daniTotal && edTotal == frankTotal)
                highSaleOutput.Text = String.Format("Everyone is doing a great job!");
            else if (edTotal > daniTotal && edTotal > frankTotal)
                highSaleOutput.Text = String.Format("Edward has the highest sales");
        }

        private void francisBtn_Click(object sender, EventArgs e)
        {
            decimal individualSale = Convert.ToDecimal(saleBox.Text);

            frankTotal += individualSale;
            frankSalesBox.Text = String.Format("{0:C}", frankTotal);
            grandTotalBox.Text = String.Format("{0:C}", daniTotal + edTotal + frankTotal);

            if (frankTotal == daniTotal && frankTotal == edTotal)
                highSaleOutput.Text = String.Format("Everyone is doing a great job!");
            else if (frankTotal > daniTotal && frankTotal > edTotal)
                highSaleOutput.Text = String.Format("Francis has the highest sales");
        }

    }
}
