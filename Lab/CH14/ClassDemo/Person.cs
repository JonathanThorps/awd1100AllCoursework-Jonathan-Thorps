using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public string FirstName
            { get { return _firstName; } set { _firstName = value; } }

        public string LastName
            { get { return _lastName; } set { _lastName = value; } }
    }
}
