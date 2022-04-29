using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Superheroes : Form
    {
        List<Hero> heroes = new List<Hero>()
        {
            new Hero(){Name="None", Likes="", Dislikes="", Powers="", Biography="", Image=null, Link="" },
            new Hero()
            {Name="Black Widow",
                Likes="Avengers",
                Dislikes="HYDRA, Red Room",
                Powers="Skilled gymnast, martial artist, and marksman, military strategist, skilled in espionage", 
                Biography="Originally a Russian spy and antagonist of Iron Man, she later defected to the United States, becoming an agent of S.H.I.E.L.D. and a member of the superhero team the Avengers.",
                Image=Properties.Resources.black_widow, 
                Link="https://en.wikipedia.org/wiki/Black_Widow_(Natasha_Romanova)"},
            new Hero()
            {Name="Deadpool", 
                Likes="jokes, mayhem, guns", 
                Dislikes="Cancer",
                Powers="Rapid healing factor, skilled martial artist, and marksman, peak physical condition", 
                Biography="Wade Winston Wilson, is a disfigured mercenary with the superhuman ability of regeneration and physical prowess. The character is known as the 'Merc with a Mouth' because of his tendency to talk and joke constantly, including breaking the fourth wall for humorous effect and running gags.", 
                Image=Properties.Resources.deadpool, 
                Link="https://en.wikipedia.org/wiki/Deadpool"},
            new Hero()
            {Name="Elektra", 
                Likes="Daredevil(Matt Murdock)", 
                Dislikes="The Kingpin, Bullseye", 
                Powers="martial artist, peak physical condition", 
                Biography="Elektra is a highly trained assassin of Greek descent who wields a pair of sai as her trademark weapons.She is a love interest of the superhero Matt Murdock/Daredevil, but her violent nature and mercenary lifestyle divide the two.", 
                Image=Properties.Resources.elektra, 
                Link="https://en.wikipedia.org/wiki/Elektra_(character)"},
            new Hero()
            {Name="Hulk", 
                Likes="Betsy Ross", 
                Dislikes="Bruce Banner", 
                Powers="Superhuman strength and durability", 
                Biography="Following his accidental exposure to gamma rays while saving the life of Rick Jones during the detonation of an experimental bomb, Banner is physically transformed into the Hulk when subjected to emotional stress, at or against his will. This transformation often leads to destructive rampages and to conflicts that complicate Banner's civilian life.", 
                Image=Properties.Resources.hulk,
                Link="https://en.wikipedia.org/wiki/Hulk"},
            new Hero()
            {Name="The Punisher", 
                Likes="guns", 
                Dislikes="criminals, terrorists", 
                Powers="Skilled marksman, martial artist, military strategy, survivalist, peak physical condition", 
                Biography="Driven by the deaths of his wife and two children, who were killed by the mob for witnessing a killing in New York City's Central Park, the Punisher wages a one-man war on crime", 
                Image=Properties.Resources.punisher, 
                Link="https://en.wikipedia.org/wiki/Punisher"},
            new Hero()
            {Name="Wolverine", 
                Likes="cigars, Jean Grey", 
                Dislikes="Sabertooth, Cyclops", 
                Powers="Healing factor, Enhanced senses, slowed aging, master martial artist, bones coated in adamantium, retractable adamantium claws, peak physical condition", 
                Biography="Wolverine is a mutant who possesses animal-keen senses, enhanced physical capabilities, a powerful regenerative ability known as a healing factor, and three retractable claws in each hand.",
                Image=Properties.Resources.wolverine, 
                Link="https://en.wikipedia.org/wiki/Wolverine_(character)"}
        };
        public Superheroes()
        {
            InitializeComponent();
            cboHeroes.Items.Add(heroes);
            cboHeroes.SelectedIndex = 0;
        }

        private void cboHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = cboHeroes.SelectedIndex;
            if (cboHeroes.SelectedIndex == 0)
            {
                lblHeroName.Text = "Please Select a Hero";
            }
            else
            {
                lblHeroName.Text = heroes[currentIndex].Name;
                lblLikes.Text = heroes[currentIndex].Likes;
                lblDislikes.Text = heroes[currentIndex].Dislikes;
                rtSuperpowers.Text = heroes[currentIndex].Powers;
                rtBiography.Text = heroes[currentIndex].Biography;
                picHeroPic.Image = heroes[currentIndex].Image;
                lblExtLink.Text = heroes[currentIndex].Link;
            }
        }
    }
}
