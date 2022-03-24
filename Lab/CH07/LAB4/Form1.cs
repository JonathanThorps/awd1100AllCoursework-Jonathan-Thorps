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
        List<Account> accounts = new List<Account>()
        {
            new Account ("pmccartney", "wings", "Paul", false),
            new Account ("rstarr", "allstarr", "Ringo", false),
            new Account ("gharrison", "wilburys", "George", false),
            new Account ("jlennon", "imagine", "John", false)
        };
        public Form1()
        {
            InitializeComponent();
            BankForm.Login();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int errorCount = 0;

            for (int i = 0; i < accounts.Count; i++)
            {
                Account account = accounts[i];

                try
                {
                    if (accounts[i].Username == username && accounts[i].Password == password)
                    {
                    lblWelcome.Text = "Welcome back " + accounts[i].FirstName + "!";
                    }
                }
                catch (NoUsernamePasswordException)
                {
                    lblWelcome.Text = "Please enter a username and password";
                }
                catch (IncorrectPasswordException)
                {
                    if (accounts[i].Password != password)
                    {
                        errorCount++;
                        lblWelcome.Text = "Incorrect Password";
                    }
                }
                catch (AccountDisabledException)
                {
                    if (errorCount > 3)
                    {
                        accounts[i].IsDisabled = true;
                        lblWelcome.Text = "Your account has been disabled";
                    }
                }
            }
            
        }
    }
}
