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
            champions.Add(new Champion() { Name = "Rukus", Type = ChampionType.FRONT_LINE, LeftMouse = "Miniguns", RightMouse = "Missile Launcher", Q = "Emitter", F = "Advance", E = "Hexa Fire" });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
