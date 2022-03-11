using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Photo
    {
        protected float _width;
        protected float _height;

        public Photo(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public float Width { get { return _width; } set { Width = value; } }
        public float Height { get { return _height; } set { Height = value; } }
        public virtual float Price { get {return Price; }
    }
}
