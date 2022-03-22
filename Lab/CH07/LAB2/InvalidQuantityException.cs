using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class InvalidQuantityException : System.ArgumentException
    {
        public InvalidQuantityException(string message) : base(message)
        {

        }
    }
}
