using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerms = searchBox.Text;
            string searchError = "Movie Not Found";

            string[] movie = new string[5];
            {
                movie[0] = "The Killer";
                movie[1] = "Rambo: First Blood Part 2";
                movie[2] = "Predator";
                movie[3] = "Lethal Weapon";
                movie[4] = "Invasion U.S.A.";
            }
        }
    }
}
