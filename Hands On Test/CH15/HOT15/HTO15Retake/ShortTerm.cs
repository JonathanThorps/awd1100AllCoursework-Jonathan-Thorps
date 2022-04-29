using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTO15Retake
{
    public class ShortTermLoan:ILoan
    {
        private string _name;
        private string _shortTerm;
        private double _amount;
        
        public ILoan ShortTerm(string name,string shortTerm,double amount)
        {
            _name = Name;
            _shortTerm = Type;
            _amount = Balance;
            return this;
        }
        public double MakePayment(double amount)
        {
            return amount = amount - 450;
        }
        public double ApplyInterest(double amount)
        {
            return amount = (amount * .10) + amount;
        }
    }
}
