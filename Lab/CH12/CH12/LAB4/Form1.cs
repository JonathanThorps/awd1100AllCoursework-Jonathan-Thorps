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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string game = txtSearchBox.Text;

            //Game<string> games = new Game();
            //{ games.name = "Player Unknown Battlegrounds (PUBG)"; games.publisher = "Bluehole"; games.price = 35; }
            //{ games.name = "League of Legends"; games.publisher = "Riot Games"; games.price = 0; }
            //{ games.name = "Call of Duty: Black OPS III"; games.publisher = "Activision"; games.price = 60; }
            //{ games.name = "Battlefield 4"; games.publisher = "Electronic Arts (EA)"; games.price = 20; }
            //{ games.name = "Super Mario Odyssey"; games.publisher = "Nintendo"; games.price = 60; }

            string[] name = new string[]
            {
                "Player Unknown Battlegrounds (PUBG)",
                "League of Legends",
                "Call of Duty: Black OPS III",
                "Battlefield 4",
                "Super Mario Odyssey"
            };
            string[] publisher = new string[]
            {
                "Bluehole",
                "Riot Games",
                "Activision",
                "Electronic Arts (EA)",
                "Nintendo"
            };
            float[] price = new float[]
            {
                35,
                0,
                60,
                20,
                60
            };

            for (int i = 0; i < 10; i++)
            {
                if (game.ToLower().Contains(name.Length.ToLower()))
                {
                    lblTitle.Text = name[i];
                    lblPublisher.Text = publisher[i];
                    lblPrice.Text = $"{price[i]}";
                }
                else if (game.ToLower().Contains(publisher.Length.ToLower()))
                {
                    lblTitle.Text = name[i];
                    lblPublisher.Text = publisher[i];
                    lblPrice.Text = $"{price[i]}";
                }
                else
                {
                    lblTitle.Text = "Game Not Found";
                    lblPublisher.Text = "Game Not Found";
                    lblPrice.Text = "Game Not Found";
                }
            }
        }
    }
}
