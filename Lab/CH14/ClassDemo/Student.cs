using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Student : Person
    {
        private int _studentId;

        public Student()
        {

        }

        public Student(string firstName, string lastName, int id) : base(firstName, lastName)
        {
            _studentId = id;
        }

        public int StudentId { get { return _studentId; } set { _studentId = value; } }
    }
}
