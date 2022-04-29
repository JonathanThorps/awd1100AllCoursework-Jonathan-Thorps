using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTO15Retake
{
    public class ILoan
    {
        private string _name;
        private string _type;
        private double _amount;

        public ILoan (string name,string type,double amount)
        {
            _name = Name;
            _type = Type;
            _amount = Balance;
        }

        public double MakePayment(double amount)
        {
            if (Type == ShortTermLoan)
            {
                amount = amount - 450;
            }
            else if (Type == LongTermLoan)
            {
                amount = amount - 200;
            }
            return amount;
        }

        public double ApplyInterest(double amount)
        {
            if (Type == ShortTermLoan)
            {
                amount = (amount * .10) + amount;
            }
            else if (Type == LongTermLoan)
            {
                amount = (amount * .05) + amount;
            }
            return amount;
        }
        public string Name { get; }
        public string Type { get; }
        public double Balance { get; }
    }
}
