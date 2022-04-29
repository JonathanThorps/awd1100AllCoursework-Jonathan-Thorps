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
                LongTermLoan longTermLoan = new LongTermLoan();
            }
            if(rbShortTerm.Checked)
            {
                ShortTermLoan shortTermLoan = new ShortTermLoan();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (rbLongTerm.Checked)
            {
                lblName.Text = txtName.Text;
                lblLoan.Text = txtAmount.Text;

                //LongTermLoan.MakePayment();
                {
                    lblPrinciple.Text = "After the last payment the loan is down to";
                }
                //LongTermLoan.ApplyInterest();
                {
                    lblBalance.Text = "After the last interest accumulation the loan is now";
                }
            }
            if (rbShortTerm.Checked)
            {
                lblName.Text = txtName.Text;
                lblLoan.Text = txtAmount.Text;

                //ShortTermLoan.MakePayment();
                {
                    lblPrinciple.Text = "After the last payment the loan is down to ";
                }
                //ShortTermLoan.ApplyInterest();
                {
                    lblBalance.Text = "After the last interest accumulation the loan is now ";
                }             
            }
        }
    }
}
