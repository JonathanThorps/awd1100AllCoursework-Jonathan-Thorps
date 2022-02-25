using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        string[] accountNumber = new string[5];
        {
        "111-222-333",
        "222-444-666",
        "333-555-777",
        "123-456-789",
        "987-654-321"
        };
        string[] accountNames = new string[5];
        {
        "Mr. Smith",
        "Mr. Jones",
        "Mrs. Harris",
        "Mrs. Rogers",
        "Dr. Hunter"
        };
        string[] accountPin = new string[5];
        {
        "1234",
        "5678",
        "2468",
        "3579",
        "9876"
        };
    decimal [] accountBalance = new decimal[5];
        {
        10000m,
        5000m,
        2000m,
        3500m,
        50000m
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccount.Text;
            string pin = txtPinNum.Text;
        
            for (int i = 0; i < accountNumber.Length; i++)
                {
                    if (accountNumber.Length == accountPin.Length)
                        {
                            lblWelcome.Text = $"Welcome back {accountNames[i]}";
                            lblBalance.Text = $"Your balance is {accountBalance[i]}";
                        }
                }   else
                        {
                            lblWelcome.Text = $"Account does not exist.";
                            lblBalance.Text = "";
                        }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string amount = txtDeposit.Text;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string amount = txtWithdraw.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
