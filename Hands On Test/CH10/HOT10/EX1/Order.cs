using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Order
    {
        public Occassion Occassion { get; set; }
        public Style Style { get; set; }
        public decimal Total { get; set; }
    }
}
