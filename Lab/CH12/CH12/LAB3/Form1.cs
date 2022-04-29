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
        List<Account> accounts = new List<Account>();
        {
            new Account("111-222-333", "Mr. Smith", "1234", 10000m),
            new Account("222-444-666", "Mr. Jones", "5678", 5000m),
            new Account("333-555-777", "Mrs. Harris", "2468", 2000m),
            new Account("123-456-789", "Mrs. Rogers", "3579", 3500m),
            new Account("987-654-321", "Dr. Hunter", "9876", 50000m)
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
