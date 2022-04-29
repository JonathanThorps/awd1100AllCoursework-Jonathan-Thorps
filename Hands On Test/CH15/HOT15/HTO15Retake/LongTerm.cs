using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTO15Retake
{
    public class LongTermLoan:ILoan
    {
        private string _name;
        private string _longTerm;
        private double _amount;

        public ILoan LongTerm(string longTerm)
        {
            longTerm = Type;
            return this;
        }
        public double MakePayment(double amount)
        {
            return amount - 200;
        }
        public double ApplyInterest(double amount)
        {
            return amount = (amount * .05) + amount; 
        }
    }
}
