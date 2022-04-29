using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AccessManager
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private int _employeeId;
        private Image _image;
        private Department _department;

        public Employee(string firstName,string lastName,int employeeId,Image Image,Department department)
        {
            _firstName = firstName;
            _lastName = lastName;
            _employeeId = employeeId;
            _image = Image;
            _department = department;
        }
        public Employee NewEmploye()
        {
            
        }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public int EmployeeId { get { return _employeeId; } set { _employeeId = value;} }
        public Image Image { get { return _image; } set { _image = value; } }
        public Department Department { get { return _department; } set { _department = value; } }
    }
}
