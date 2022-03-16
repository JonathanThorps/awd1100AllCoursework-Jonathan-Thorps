using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class ShortTermLoan : ILoan
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
            balance = balance - 450;
            return balance;
        }
        public double ApplyInterest(double balance)
        {
            balance = (balance * .10) + balance;
            return balance;
        }
        public string Name(string name)
        {
            return _name;
        }
        public string Type(string type)
        {
            return "Short Term";
        }
        public double Balance { get { return _balance; } }
}
