using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2
{
    public class Dog
    {
        public Dog()
        { 
        
        }

        public string Dog(string breed, int age)
        {
            _breed = breed;
            _age = age;
        }

        private string _breed;
        private int _age;

        public string Breed;
        {
            get { return _breed; }
            set { _breed = value; } 
        }

        public int Age;
        {
            get { return _age; }
            set { _age = value; }
        }

        public string GetBreed(string breed)
        {
            return breed;
        }
        public void SetBreed(string breed)
        {
            _breed = breed;
        }
        public int GetAge(int age)
        {
            return age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
    }
}
