﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class InvalidNumberException : System.ArgumentException
    {
        public InvalidNumberException(string message) : base(message)
        {

        }
    }
}
