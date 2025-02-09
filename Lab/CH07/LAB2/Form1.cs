﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                short itemNumber = (short)Convert.ToInt32(txtItemNum.Text);
                byte quantity = Convert.ToByte(txtQuantity.Text);
                byte estimatedDelivery = Convert.ToByte(txtDeliveryDays.Text);

                Order myOrder = new Order(itemNumber, quantity, estimatedDelivery);

            }
            catch(InvalidNumberException)
            {
                lblValidation.Text = "Order is Invalid!";
            }
            catch(InvalidQuantityException)
            {
                lblValidation.Text = "Order is Invalid!";
            }
            catch(InvalidDeliveryDaysException)
            {
                lblValidation.Text = "Order is Invalid!";
            }
        }
    }
}
