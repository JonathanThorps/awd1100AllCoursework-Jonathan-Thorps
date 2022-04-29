using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Occassion
    {
        private string _name;
        private Style[] style;

        public Occassion(string name, Style[] style)
        {
            _name = name;
            this.style = style;
        }
    }
}
