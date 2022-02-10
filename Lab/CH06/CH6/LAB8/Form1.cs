using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void estimateBtn_Click(object sender, EventArgs e)
        {
            GetWood();

            GetDrawers();

            CalculateWoodCost();

            CalculateDrawerCost();

            CalculateTotalCost();
        }

        private string GetWood()
        {
            string woodType = woodTypeBox.Text;
        }

        private int GetDrawers()
        {
            int numDrawers = Convert.ToInt32(numDrawerBox.Text);
            
        }

        private double CalculateWoodCost(string woodType)
        {
            if (woodTypeBox.Text == "mahogany")
            {
                lblWoodCost.Text = String.Format("{0:C}", 180);
            }
            else if (woodTypeBox.Text == "oak")
            {
                lblWoodCost.Text = String.Format("{0:C}", 140);
            }
            else if (woodTypeBox.Text == "pine")
            {
                lblWoodCost.Text = String.Format("{0:C}", 100);
            }
            else 
            {
                lblWoodCost.Text = String.Format("{0:C}", 180);
            }

        }

        private double CalculateDrawerCost(int numDrawers)
        {
            decimal drawerRate = 30m;

            lblDrawerCost.Text = String.Format("{0:C}", numDrawers * drawerRate);
        }

        private double CalculateTotalCost(string woodType, int numDrawers)
        {
            decimal drawerCost = Convert.ToDecimal(lblDrawerCost.Text);
            decimal woodCost = Convert.ToDecimal(lblWoodCost.Text);

            lblTotalCost.Text = String.Format("{0:C}", drawerCost + woodCost);
        }
    }
}
