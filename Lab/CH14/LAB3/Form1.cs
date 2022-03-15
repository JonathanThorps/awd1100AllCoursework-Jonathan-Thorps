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
        List<ICard> selectedCards = new List<ICard> ();

        List<NormalCard> normalCards = new List<NormalCard>()
        {
            new NormalCard("Arbok",1,Properties.Resources.arbok),
            new NormalCard("Bulbasaur",2,Properties.Resources.bulbasaur),
            new NormalCard("Jigglypuff",3,Properties.Resources.jigglypuff),
            new NormalCard("Kadabra",4,Properties.Resources.kadabra),
            new NormalCard("Mudkip",5,Properties.Resources.mudkip),
            new NormalCard("Pidgeot",6,Properties.Resources.pidgeot),
            new NormalCard("Pikachu",7,Properties.Resources.pikachu),
            new NormalCard("Piplup",8,Properties.Resources.piplup),
            new NormalCard("Purugly",9,Properties.Resources.purugly),
            new NormalCard("Voltorb",10,Properties.Resources.voltorb)

        };
        List<ShinyCard> shinyCards = new List<ShinyCard>()
        {
            new ShinyCard("Charizard",Properties.Resources.shiny_charizard,11,new Font("arial",8),Color.Yellow,Color.Red),
            new ShinyCard("Ditto",Properties.Resources.shiny_ditto,12,new Font ("arial",8),Color.Yellow,Color.Red),
            new ShinyCard("Hawlucha",Properties.Resources.shiny_hawlucha,13,new Font("arial",8),Color.Yellow,Color.Red),
            new ShinyCard("Greninja",Properties.Resources.shiny_greninja,14,new Font ("arial",8),Color.Yellow,Color.Red),
            new ShinyCard("Gyarados",Properties.Resources.shiny_gyarados,15,new Font("arial",8),Color.Yellow,Color.Red),
            new ShinyCard("Heracross",Properties.Resources.shiny_heracross,16,new Font("arial",8),Color.Yellow,Color.Red),
            shinyCards.Add(new ShinyCard("Liepard")),
            shinyCards.Add(new ShinyCard("Noctowl")),
            shinyCards.Add(new ShinyCard("Slowbro")),
            new ShinyCard("Sylveon",Properties.Resources.shiny_sylveon,20,new Font("arial",8),Color.Yellow,Color.Red)
        };
        //System.Drawing.Color backcolor = ;
        //System.Drawing.Font font = null;

        public Form1()
        {
            InitializeComponent();
           // pictureBox1.Image = Properties.Resources.arbok;
        }

        private void btnOpenPack_Click(object sender, EventArgs e)
        {
            //    for (int i = 0; i < Cards.Count; i++)
            //    //Random number generator for Normal Cards
            //    Random normalCard = new Random();
            //    //Random number generator for Shiny Cards
            //    Random shinyCard = new Random();
            selectedCards.Add(normalCards[0]);

            selectedCards[0].ShowCard(pictureBox1, label1);
        }
    }
}
