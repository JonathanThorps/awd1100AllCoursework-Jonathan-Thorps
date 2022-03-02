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
            new Account ("123-456-789", "1234", "Mr. Jones", 10000m),
            new Account ("234-567-890", "2345", "Mrs. Jackson", 2500m),
            new Account ("345-678-901", "3456", "Dr. Petersen", 50000m),
            new Account ("456-789-012", "4567", "Ms. Lee", 10000m),
            new Account ("567-890-123", "5678", "Mr. Bond", 70000m),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
        string accountNum = "";
        string pinNumber = "";
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }
        private void Login()
        { 
            for ()
        }
    }
}
