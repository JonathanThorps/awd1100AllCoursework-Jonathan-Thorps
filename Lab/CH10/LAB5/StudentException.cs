using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class StudentException : Exception
    {
        public StudentException(string message) : base(message)
        {

        }
    }
}
