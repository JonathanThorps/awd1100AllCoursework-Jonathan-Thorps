using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class InvalidCharacterException : System.Exception
    {
        public InvalidCharacterException(string message) : base(message)
        {

        }
    }
}
