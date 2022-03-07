using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        string orderError = "Name required/No food selected";
        string sundaeError = "Only 2 toppings allowed";
        string sodaError = "Only 1 Mixin allowed";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string orderName = txtNameBox.Text;

            if (chkSundae.Checked && chkSoda.Checked || !String.IsNullOrEmpty(orderName))
            {
                
            }
            else
            {
                lblNameError.Text = orderError;
            }
        }
        public void CompleteOrder()
        {
            
        }
    }
}
