using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class Student
    {
        private int _studentId;
        private string _firstName;
        private string _lastName;
        private string _email;

        public Student(int studentId, string firstName, string lastName, string email)
        {
            _studentId = studentId;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }
        public int StudentId { get { return _studentId; } }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public string Email { get { return _email; } } 
    }
   
}
