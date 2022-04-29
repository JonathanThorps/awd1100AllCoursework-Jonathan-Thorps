using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    public class Style
    {
        private string _name;
        private decimal _price;
        private Image _image;

        public Style(string name, decimal price, Image image)
        {
            _name = name;
            _price = price;
            _image = image;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public Image Image { get { return _image; } set { _image = value; } }
    }
}
