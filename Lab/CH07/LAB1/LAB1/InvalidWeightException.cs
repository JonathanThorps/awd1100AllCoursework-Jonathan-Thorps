﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class InvalidWeightException : ApplicationException
    {
        public InvalidWeightException(string message) : base(message)
        {

        }
    }
}
