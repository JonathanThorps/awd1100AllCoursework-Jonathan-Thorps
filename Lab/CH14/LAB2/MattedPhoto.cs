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
        public Colors Color { get { return _color; } set { Color = value; } }
        public override float Price
        {
            get

            {
                if (_color != null)
                {
                    return base.Price + 10f;
                }
                return Price;
            }
        }
    }
}
