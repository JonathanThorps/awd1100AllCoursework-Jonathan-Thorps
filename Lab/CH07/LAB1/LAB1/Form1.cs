using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            { 
                float weight = Convert.ToSingle(txtWeight.Text);
                float height = Convert.ToSingle(txtHeight.Text);
                Bmi userBmi = (BmiCalculator.CalcBmi(weight, height));
                lblBmiCategory.Text = userBmi.WeightCategory.ToString();
                lblBmiResult.Text = userBmi.BMI.ToString() ;
            }
            catch (InvalidWeightException)
            {
                lblErrorMsg.Text = "INVALID WEIGHT";
            }
            catch (InvalidHeightException)
            {
                lblErrorMsg.Text = "INVALID HEIGHT";
            }
        }
            
    }
}
