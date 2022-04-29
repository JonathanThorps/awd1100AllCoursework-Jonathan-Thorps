using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public class NormalCard : ICard
    {
        private string _name;
        private double _value;
        private System.Drawing.Image _image;

        public NormalCard(string name, double value, System.Drawing.Image image)
        {
            _name = name;
            _value = value;
            _image = image;
        }
        //public ShowCard(Picturebox picture, Label label)
        //{

        //}
        public string Name { get { return _name; } }
        public System.Drawing.Image Image { get { return _image; } }
        public double Value { get { return _value; } }

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image;
            label.Text = _name;
        }

        public int CompareTo(ICard other)
        {
            throw new NotImplementedException();
        }
    }
}
