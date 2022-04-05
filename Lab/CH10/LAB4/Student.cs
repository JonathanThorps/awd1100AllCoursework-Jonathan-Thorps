using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _course;
        private char _grade;
        private double _gpa;

        public Student(string firstName, string lastName, string course, char grade, double gpa)
        {
            _firstName = firstName;
            _lastName = lastName;
            _course = course;
            _grade = grade;
            _gpa = gpa;

            if (string.IsNullOrEmpty(firstName))
            {
                throw new StudentException("First Name can't be blank");
            }
            if (string.IsNullOrEmpty(lastName))
            {
                throw new StudentException("Last Name can't be blank");
            }
        }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public string Course { get { return _course; } }
        public char Grade { get { return _grade; } }
        public double Gpa { get { return _gpa; } }
    }
}
