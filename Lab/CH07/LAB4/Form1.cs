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
            new Account ("jlennon", "", "John", false)
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    
                }
            }
            catch(NoUsernamePasswordException)
            {
                lblWelcome.Text = "Please enter a username and password";
            }
            catch(IncorrectPasswordException)
            {
                lblWelcome.Text = "Incorrect Password";
            }
            catch(AccountDisabledException)
            {
                lblWelcome.Text = "Your account has been disabled";
            }
        }
    }
}
