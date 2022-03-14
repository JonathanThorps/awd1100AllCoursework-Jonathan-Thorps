using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class MattedPhoto : Photo
    {
        protected Colors _color;

        public MattedPhoto(float width, float height, Colors color) : base(width, height)
        {
            Width = width;
            Height = height;
            _color = color;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Colors Color { get { return _color; } set { _color = value; } }
        public override float Price => base.Price;
        {
          
        }
    }
}
