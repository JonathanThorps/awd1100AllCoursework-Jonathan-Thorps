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
            Game game = new Game();
            Game<List> games = new Game();
            { games.name = "Player Unknown Battlegrounds (PUBG)"; games.publisher = "Bluehole"; games.price = 35; }
            { games.name = "League of Legends"; games.publisher = "Riot Games"; games.price = 0; }
            { games.name = "Call of Duty: Black OPS III"; games.publisher = "Activision"; games.price = 60; }
            { games.name = "Battlefield 4"; games.publisher = "Electronic Arts (EA)"; games.price = 20; }
            { games.name = "Super Mario Oddessy"; games.publisher = "Nintendo"; games.price = 60; }
        }
    }
}
