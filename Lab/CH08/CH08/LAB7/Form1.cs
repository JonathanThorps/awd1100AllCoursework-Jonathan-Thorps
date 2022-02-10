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
            string[] director = new string[5];
            {
                director[0] = "John Woo";
                director[1] = "George P. Cosmatos";
                director[2] = "John McTiernan";
                director[3] = "Richard Donner";
                director[4] = "Joseph Zito";
            }
            string[] description = new string[5];
            {
                description[0] = "A hitman seeks redemption";
                description[1] = "Former soldier is called to action by his country";
                description[2] = "An alien hunter seeks elite prey";
                description[3] = "Cop gets new crazy partner to take down mercenaries";
                description[4] = "One man army seeks to stop invasion of America";
            }
            for (int i = 0; i < movie.Length || i < director.Length; i++)
                {
                if (movie[i].ToLower().Contains(searchTerms.ToLower()) || director[i].ToLower().Contains(searchTerms.ToLower()))
                {
                    lblTitleOut.Text = movie[i];
                    lblDirectorOut.Text = director[i];
                    lblDescription.Text = description[i];
                    break;
                }
                else
                {
                    lblTitleOut.Text = searchError;
                    lblDirectorOut.Text = searchError;
                    lblDescription.Text = searchError;
                }
            }
        }
    }
}
