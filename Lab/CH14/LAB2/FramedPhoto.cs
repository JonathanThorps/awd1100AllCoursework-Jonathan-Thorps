using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class FramedPhoto : Photo
    {
        protected Materials _material;
        protected Styles _style;

        public FramedPhoto(float width, float height, Materials material, Styles style) : base(width, height)
        {
            _style = style;
            _material = material;
        }
        public override string ToString()
        {
            return base.ToString() + Material + Style;
        }
        public Materials Material { get { return _material; } set { Material = value; } }
        public Styles Style { get { return _style; } set { Style = value; } }
        public override float Price
        {
            get

            {

                if (_style != null && _material != null)
                {
                    return base.Price + 25f;
                }
                return Price;
            }
        }
    }
}
