using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int product = 0;

                product = num1 * num2;

                txtOutput.Text = product.ToString();
            }
            catch (ArithmeticException)
            {
                throw new ArithmeticException();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int sum = 0;

                sum = num1 + num2;
                txtOutput.Text = sum.ToString();
            }
            catch(ArithmeticException)
            {
                throw new ArithmeticException();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int difference = 0;

                difference = num1 - num2;
                txtOutput.Text = difference.ToString();
            }
            catch(ArithmeticException)
            {
                throw new ArithmeticException();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int quotient = 0;

                quotient = num1 / num2;
                txtOutput.Text = quotient.ToString();
            }
            catch(ArithmeticException)
            {
                throw new ArithmeticException();
                
                lblError.Visible = true;
            }
        }
    }
}
