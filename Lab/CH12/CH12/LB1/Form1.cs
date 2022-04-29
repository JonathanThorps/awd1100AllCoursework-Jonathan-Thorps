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
        Order anOrder;
        double grandTotal = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string orderName = txtNameBox.Text;

            if ((chkSundae.Checked || chkSoda.Checked) && !String.IsNullOrEmpty(orderName))
            {
                lblNameError.Visible = false;
                anOrder = new Order(orderName, chkSundae.Checked, chkSoda.Checked);

                if (chkSprinkles.Checked && chkNuts.Checked && chkChocoSyrup.Checked)
                {
                    lblSundaeError.Visible = true;
                }
                else
                {
                    lblSundaeError.Visible = false;

                    if (chkSprinkles.Checked)
                    {
                        anOrder.Sundae.AddToppings(SundaeTopping.SPRINKLES);
                    }
                    if (chkNuts.Checked)
                    {
                        anOrder.Sundae.AddToppings(SundaeTopping.NUTS);
                    }
                    if (chkChocoSyrup.Checked)
                    {
                        anOrder.Sundae.AddToppings(SundaeTopping.CHOCLOATE_SYRUP);
                    }
                    else
                    {
                        anOrder.Sundae.AddToppings(SundaeTopping.NONE);
                    }

                if (chkLime.Checked && chkMango.Checked ||chkLime.Checked && chkPeach.Checked || chkPeach.Checked && chkMango.Checked)
                    {
                        lblDrinkError.Visible = true;
                    }
                    else
                    {
                        lblDrinkError.Visible = false;

                        if (chkLime.Checked)
                        {
                            anOrder.Soda.AddFlavor(SodaFlavor.LIME);
                        }
                        if (chkMango.Checked)
                        {
                            anOrder.Soda.AddFlavor(SodaFlavor.MANGO);
                        }
                        if (chkPeach.Checked)
                        {
                            anOrder.Soda.AddFlavor(SodaFlavor.PEACH);
                        }
                        else
                        {
                            anOrder.Soda.AddFlavor(SodaFlavor.NONE);
                        }

                        grandTotal = anOrder.Price;
                        lblTotal.Text = grandTotal.ToString("C");

                        rtOutput.Text += anOrder.Name;
                        rtOutput.Text += "\n-----------------------";

                        if (anOrder.Sundae == null)
                        {
                            rtOutput.Text = "SODA - ";
                            rtOutput.Text = "\n-----------------------";
                            rtOutput.Text += anOrder.Soda.Flavor;
                            rtOutput.Text += anOrder.Soda.Price.ToString("C") + "\n\n";
                        }
                        else if (anOrder.Soda == null)
                        {
                            rtOutput.Text += "SUNDAE - ";
                            int toppingCount = anOrder.Sundae.ToppingCount;

                            if (toppingCount == 0)
                            {
                                rtOutput.Text += anOrder.Sundae.GetTopping(0) + "-\n";
                            }
                            else
                            {
                                for (int i = 0; i < toppingCount; i++)
                                {
                                    rtOutput.Text += anOrder.Sundae.GetTopping(i) + " ";
                                }
                            }
                            rtOutput.Text += anOrder.Sundae.Price.ToString("C") + "\n";
                            
                        }
                        else
                        {
                            rtOutput.Text += anOrder.Sundae;
                            rtOutput.Text += anOrder.Soda;
                        }
                        
                    }

                }
            }

            else
            {
                lblNameError.Visible = true;
            }
        }
        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSundae.Checked)
            {
                grpToppings.Visible = true;
            }
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSoda.Checked)
            {
                grpMixins.Visible = true;
            }
        }
    }
}
