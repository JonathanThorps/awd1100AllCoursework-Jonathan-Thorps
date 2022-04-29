using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {
        List<Champion> champions = new List<Champion>();
        
        public Form1()
        {
            InitializeComponent();

            champions.Add(new Champion("Ruckus", ChampionType.FRONT_LINE, new Ability("Miniguns"), new Ability("Missile Launcher"), new Ability("Emitter"), new Ability("Advance"), new Ability("Hexa Fire")));
            champions.Add(new Champion("Makoa", ChampionType.FRONT_LINE, new Ability("Cannon"), new Ability("Dredge Anchor"), new Ability("Shell Shield"), new Ability("Shell Spin"), new Ability("Ancient Rage")));
            champions.Add(new Champion("Drogoz", ChampionType.DAMAGE, new Ability("Rocket Launcher"), new Ability("Fire Spit"), new Ability("Salvo"), new Ability("Thrust"), new Ability("Dragon Punch")));
            champions.Add(new Champion("Tyra", ChampionType.DAMAGE, new Ability("Auto Rifle"), new Ability("Nade Launcher"), new Ability("Fire Bomb"), new Ability("Hunter's Mark"), new Ability("Crossfire")));
            champions.Add(new Champion("Grover", ChampionType.SUPPORT, new Ability("Throwing Axe"), new Ability("Crippling Throw"), new Ability("Blossom"), new Ability("Vine"), new Ability("Whirlwind")));
            champions.Add(new Champion("Evie", ChampionType.FLANK, new Ability("Ice Staff"), new Ability("Ice Block"), new Ability("Blink"), new Ability("Soar"), new Ability("Ice Storm")));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtChampSearch.Text;
            bool foundChamp = false;
            for (int i = 0; i < champions.Count; i++)
            {
                if (champions[i].Name.ToLower().Contains(searchTerm.ToLower()))
                {
                    lblChampion.Text = champions[i].Name;
                    lblChampType.Text = champions[i].Type.ToString();
                    lblLeftMouse.Text = champions[i].LeftMouse.ToString();
                    lblRightMouse.Text = champions[i].RightMouse.ToString();
                    lblQAttack.Text = champions[i].Q.ToString();
                    lblFAttack.Text = champions[i].F.ToString();
                    lblEAttack.Text = champions[i].E.ToString();
                    foundChamp = true;
                }
               
            }

            if(!foundChamp)
            {
                
                    lblChampion.Text = "Champion Not Found";
                
            }


        }
    }
}
