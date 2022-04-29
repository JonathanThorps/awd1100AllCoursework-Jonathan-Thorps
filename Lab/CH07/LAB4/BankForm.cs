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
    public partial class BankForm : Form
    {
        List<Account> accounts = new List<Account>()
        {
            new Account ("pmccartney", "wings", "Paul", false),
            new Account ("rstarr", "allstarr", "Ringo", false),
            new Account ("gharrison", "wilburys", "George", false),
            new Account ("jlennon", "imagine", "John", false),
            new Account ("eclapton", "blues", "Eric", false)
        };
        public BankForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
          
            Account account;

                try
                {
                    account = Login(username, password);
                
                    lblWelcome.Text = "Welcome back " + account.FirstName + "!";
                }
                catch (NoUsernamePasswordException)
                {
                    lblWelcome.Text = "Please enter a username and password";
                }
                catch (IncorrectPasswordException)
                {
                    lblWelcome.Text = "Invalid Username or Password! Please try again.";
                }
                catch (AccountDisabledException)
                {
                    lblWelcome.Text = "Your account has been disabled";
                }
        }

        public Account Login(string username,string password)
        {
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                throw new NoUsernamePasswordException("No username or password");
            }

            Account searchAccount = null;
            int errorCount = 0;

            //search for matching username and password
            //if found return that account
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == username && accounts[i].Password == password && accounts[i].IsDisabled == false)
                {
                    searchAccount = accounts[i];

                    if(searchAccount.IsDisabled)
                    {
                        throw new AccountDisabledException("Account disabled");
                    }
                    return searchAccount;
                }
                else if (accounts[i].Username == username && accounts[i].Password != password || 
                    accounts[i].Username != username && accounts[i].Password == password)
                {
                    errorCount++;
                    throw new IncorrectPasswordException("Username or Password Incorrect");
                }
                //else if (accounts[i].Password == password && accounts[i].Username == username && accounts[i].IsDisabled == true)
                //{
                //    searchAccount = accounts[i];
                //    return searchAccount;
                   
                //}          

                if (errorCount > 3)
                {
                    accounts[i].IsDisabled = true;
                    throw new AccountDisabledException("Account disabled");
                }
            }

            if (searchAccount == null)
            {
                    throw new IncorrectPasswordException("Incorrect Username or Password");
            }

            return searchAccount;
        }
    }
}
