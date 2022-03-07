﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Order
    {
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        public string Name
        {
            get { return _name; }
        }

        public Sundae Sundae
        {
            get { return _sundae; }
        }

        public Soda Soda
            {
                get {return _soda; }
            }

        public double Price
        {
            get { return _sundae.Price + _soda.Price; }
        }

        public Order(string name, bool hasSundae, bool hasSoda)
        {
            _name = name;

            if (hasSundae)
            {
                _sundae = new Sundae();
            }
            if (hasSoda)
            {
                _soda = new Soda();
            }
        }
    }
}
