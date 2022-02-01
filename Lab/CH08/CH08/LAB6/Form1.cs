using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
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
            string searchError = "Game Not Found";
            string[] gameTitle = new string[5];
            {
                gameTitle[0] = "Player Unknown Battlegrounds (PUBG)";
                gameTitle[1] = "League of Legends";
                gameTitle[2] = "Call of Duty: Black OPS III";
                gameTitle[3] = "Battlefield 4";
                gameTitle[4] = "Super Mario Galaxy";
            }
            string[] gamePublisher = new string[5];
            {
                gamePublisher[0] = "Bluehole";
                gamePublisher[1] = "Riot Games";
                gamePublisher[2] = "Activision";
                gamePublisher[3] = "Electronic Arts";
                gamePublisher[4] = "Nintendo";
            }
            decimal[] price = new decimal[5];
            {
                price[0] = 35;
                price[1] = 0;
                price[2] = 60;
                price[3] = 20;
                price[4] = 60;
            }
            for (int i = 0; i < gameTitle.Length || i < gamePublisher.Length; i++)
                {
                    if (gameTitle[i].ToLower().Contains(searchTerms.ToLower()) || gamePublisher[i].ToLower().Contains(searchTerms.ToLower()))
                    {
                    titleBox.Text = gameTitle[i];
                    publisherBox.Text = gamePublisher[i];
                    priceBox.Text = String.Format("{0:C}", price[i]);
                    break;
                    }
                    else
                    {
                    titleBox.Text = searchError;
                    publisherBox.Text = searchError;
                    priceBox.Text = searchError;
                    }
                }
               
         }
    }
}
