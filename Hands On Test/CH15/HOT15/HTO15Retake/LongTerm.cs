using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTO15Retake
{
    public abstract class LongTerm:ILoan
    {
        private string _name;
        private double _balance;

        public LongTerm(string name,double balance)
        {
            _name = name;
            _balance = balance;
        }
        public double MakePayment(double balance)
        {
            return balance - 200;
        }
        public double ApplyInterest(double balance, double interest)
        {
            return interest = (balance * .05) + balance; 
        }
    }
}
