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
       
        public Form1()
        {
            InitializeComponent();
            decimal gradePointAverage = Convert.ToDecimal(gpaScoreBox.Text);
            decimal admitTestScore = Convert.ToDecimal(testScoreBox.Text);

        }

        private void admitBtn_Click(object sender, EventArgs e)
        {
            IsStudentAccepted();

        }
        private void IsStudentAccepted()
        {
            if (gradePointAverage > 3 && admitTestScore > 60)
            {
            lblAdmitOutput.Text = "Accept";
            }
            else if (gradePointAverage < 3 && admitTestScore > 80)
            {
            lblAdmitOutput.Text = "Accept";
            }
            else
            {
            lblAdmitOutput.Text = "Reject";
            }
        }

            
    }
}
