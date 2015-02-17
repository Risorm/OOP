using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Interest_Calculator
{
    public class InterestCalculator
    {
        public InterestCalculator(decimal amount, decimal interest, int years, CalculateInterest simpleOrCompound)
        {
            this.Amount = amount;
            this.Interest = interest;
            this.Years = years;
            this.Result = simpleOrCompound(amount, interest, years);
        }
        public delegate decimal CalculateInterest(decimal amount, decimal interest, int years);
        public decimal Amount { get; set; }

        public decimal Interest { get; set; }

        public int Years { get; set; }
        public decimal Result { get; set; }
    }
}
