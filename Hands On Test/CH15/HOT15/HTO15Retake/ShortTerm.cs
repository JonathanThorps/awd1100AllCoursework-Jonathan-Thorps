using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTO15Retake
{
    public class ShortTermLoan:ILoan
    {
        private string _shortTerm;
        
        public ILoan ShortTerm(string shortTerm)
        {
            shortTerm = Type;
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
