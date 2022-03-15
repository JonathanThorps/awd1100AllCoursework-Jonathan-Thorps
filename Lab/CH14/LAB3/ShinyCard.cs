using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public class ShinyCard : ICard
    {
        private string _name;
        private double _value;
        private System.Drawing.Image _image;
        private System.Drawing.Font _font;
        private System.Drawing.Color _backColor;
        private System.Drawing.Color _foreColor;

        public ShinyCard(string name, System.Drawing.Image image, double value, System.Drawing.Font font,
            System.Drawing.Color backColor, System.Drawing.Color foreColor)
        {
            _name = name;
            _value = value;
            _image = image;
            _font = font;
            _backColor = backColor;
            _foreColor = foreColor;
        }
        //public void ShowCardPicture(PictureBox picture, Label label)
        //{
           
        //}

        public void ShowCard(PictureBox picture, Label label)
        {
             picture.Image = _image;
            label.Text = _name;
            label.BackColor = _backColor;
        }

        public int CompareTo(ICard other)
        {
            throw new NotImplementedException();
        }

        public string Name { get { return _name; } }
        public System.Drawing.Image Image { get { return _image; } }
        public double Value { get { return _value; } }
    }
}
