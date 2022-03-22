using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class InvalidDeliveryDaysException : System.ArgumentException
    {
        public InvalidDeliveryDaysException(string message) : base(message)
        {

        }
    }
}
