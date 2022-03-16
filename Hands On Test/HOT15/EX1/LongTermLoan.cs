using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class LongTermLoan : ILoan
    {
        private string _name;
        private string _type;
        private double _balance;
        public CreateLoan(string name,string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }
        public double MakePayment(double balance)
        {
            balance = balance - 200;
            return balance;
        }
        public double ApplyInterest(double balance)
        {
            balance = (balance * .05) + balance;
            return balance;
        }
        public string Name(string name)
        {
            return _name;
        }
        public string Type(string type)
        {
            return "Long Term";
        }
        public double Balance { get { return _balance; } 
    }
}
