using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        List<LongTermLoan> longTerm = new List<LongTermLoan>();
        List<ShortTermLoan> shortTerm = new List<ShortTermLoan>();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            double loanRequest = Convert.ToDouble(txtLoanAmt.Text);
            string loanType = null;

            lblBusinessName.Text = customerName;
            lblLoanType.Text = String.Format("{0} {1}", loanRequest, loanType);
            lblLoanBalance.Text = ;
            lblBalInterest.Text = ;

            if (loanRequest < 0)
            {
                lblLoanError.Visible = false;
            }

            if (rbShortTerm.Checked)
            {
                loanType = "Short Term";
                ShortTermLoan myShortTerm = new ShortTermLoan(customerName, loanRequest);
            }
            if (rbLongTerm.Checked)
            {
                loanType = "Long Term";
                LongTermLoan myLongTerm = new LongTermLoan(customerName, loanRequest);
            }
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            double loanRequest = Convert.ToDouble(txtLoanAmt.Text);
            if (rbShortTerm.Checked)
            {
                //monthly payment of $450 and 10% interest rate
                ShortTermLoan.MakePayment(loanRequest);
                ShortTermLoan.ApplyInterest(loanRequest);
            }
            if (rbLongTerm.Checked)
            {
                //monthly payment of $200 and 5% interest rate
                LongTermLoan.MakePayment(loanRequest);
                LongTermLoan.ApplyInterest(loanRequest);
            }
        }

        private void rbShortTerm_CheckedChanged(object sender, EventArgs e)
        {
            //Short term Loan Type
        }

        private void rbLongTerm_CheckedChanged(object sender, EventArgs e)
        {
            //Long term Loan Type
        }

    }
}
