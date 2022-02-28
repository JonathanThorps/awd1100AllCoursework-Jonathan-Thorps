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
        List<Game> games = new List<Game>()
            {
                new Game("Player Unknown Battlegrounds (PUBG)", "Bluehole",35),
                new Game("League of Legends", "Riot Games", 0),
                new Game("Call of Duty: Black OPS III", "Activision", 60),
                new Game("Battlefield 4", "Electronic Arts (EA)", 20),
                new Game("Super Mario Odyssey", "Nintendo", 60)
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string gameSearch = txtSearchBox.Text;

            int gamePosition = SearchForGame(gameSearch);
            SearchForGame(gameSearch);
            ShowGameInfo(gamePosition);
          
            //string[] name = new string[]
            //{
            //    "Player Unknown Battlegrounds (PUBG)",
            //    "League of Legends",
            //    "Call of Duty: Black OPS III",
            //    "Battlefield 4",
            //    "Super Mario Odyssey"
            //};
            //string[] publisher = new string[]
            //{
            //    "Bluehole",
            //    "Riot Games",
            //    "Activision",
            //    "Electronic Arts (EA)",
            //    "Nintendo"
            //};
            //float[] price = new float[]
            //{
            //    35,
            //    0,
            //    60,
            //    20,
            //    60
            //};
           
        }

        public int SearchForGame(string gameSearch)
        {
            int gameIndex = -1; //-1 means game not found
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].GetName().ToLower().Contains(gameSearch.ToLower()))
                {
                    
                    gameIndex = i;
                }
                else if (games[i].GetPublisher().ToLower().Contains(gameSearch.ToLower()))
                {
                    
                    gameIndex = i;
                }

            }
            return gameIndex;


        }
    
        public void ShowGameInfo(int gamePosition)
        {
            //for (int i = 0; i < games.Count; i++)
            //{
                if (gamePosition > -1)
                {
                    lblTitle.Text = games[gamePosition].GetName();
                    lblPublisher.Text = games[gamePosition].GetPublisher();
                    lblPrice.Text = Convert.ToString(games[gamePosition].GetPrice());
                }
                else
                {
                    lblTitle.Text = "Game Not Found";
                    lblPublisher.Text = "Game Not Found";
                    lblPrice.Text = "Game Not Found";
                }
            //}
            
        }
    
    }
}
