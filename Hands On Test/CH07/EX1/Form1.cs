using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class TestScoresForm : Form
    {
        public TestScoresForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            float score = (float)Convert.ToDecimal(txtScoreBox.Text);
            try
            {
                TestStatistics newScore = AddScore(score);

                lblNumScores.Text += ToString();
                lblSumScores.Text += ToString();
                lblAvgScore.Text += ToString();
                lblHighestScore.Text += ToString();
                lblLowestScore.Text += ToString();
            }
            catch (ArgumentException)
            {
                lblScoreError.Visible = true;
            }
        }
    }
}
