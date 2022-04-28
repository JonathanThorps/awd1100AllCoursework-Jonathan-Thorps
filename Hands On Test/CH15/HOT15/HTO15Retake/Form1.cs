using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTO15Retake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeLoan_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double amount = Convert.ToDouble(txtAmount.Text);

            if (amount < 0)
            {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }

            if (rbLongTerm.Checked)
            {
                LongTerm newLong = LongTerm();
            }
            if(rbShortTerm.Checked)
            {
                ShortTerm newShort = ShortTerm();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblLoan.Text = txtAmount.Text;
            lblPrinciple.Text = "After the last payment the loan is down to ";
            lblBalance.Text = "After the last interest accumulation the loan is now ";
        }
    }
}
