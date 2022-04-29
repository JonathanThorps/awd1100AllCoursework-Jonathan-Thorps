using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Teacher : Person
    {
        private double _salary;
        public Teacher()
        {

        }
        public Teacher(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            _salary = salary;
        }
        public double Salary { get { return _salary; } set { _salary = value; } }
    }
}
