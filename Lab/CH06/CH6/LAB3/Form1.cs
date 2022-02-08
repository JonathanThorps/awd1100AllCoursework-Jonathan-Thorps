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
        string[] fortunes =
            {
             "Birthdays are like friends. The more you have the better.",
             "Your smile is a treasure to all who know you.",
             "You never hesitate to tackle the most difficult problems.",
             "The most obvious solution is not always the best.",
             "If you want the rainbow, you will have to tolerate the rain.",
             "The early bird gets the worm, but the second mouse gets the cheese.",
             "From listening comes wisdom and from speaking repentance.",
             "A smile is your personal welcome mat."
            };
    public Form1()
        {
            InitializeComponent();
        }

        private void openCookieBtn_Click(object sender, EventArgs e)
        {
            GenerateFortune();
            //int rounds = 3;        

            //do
            //    for (int i = 0; i < rounds; i++)
            //    {

            //    }
            //    (while) i < rounds;

        }


        private void GenerateFortune()
        {
            //Everything happens here

            //Generate 2 random numbers
            Random random = new Random();

            int firstFortune = random.Next(fortunes.Length);
            int secondFortune = random.Next(fortunes.Length);

            //Output the array's data using the random numbers
            lblFortune1.Text = fortunes[firstFortune];
            lblFortune2.Text = fortunes[secondFortune];
        }
    }
}
