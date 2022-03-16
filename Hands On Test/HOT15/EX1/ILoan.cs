using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public interface ILoan
    {

        double MakePayment();
        double ApplyInterest();
        string Name { get; }
        string Type { get; }
        double Balance { get; }
    }
}
