using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LAB1
{
    public class Hero
    {
        public Hero() { }
        public string Name { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Powers { get; set; }
        public string Biography { get; set; }
        public string Link { get; set; }
        public Image Image { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
   
}
