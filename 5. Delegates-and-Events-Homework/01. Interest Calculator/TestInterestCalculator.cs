using System;

namespace _01.Interest_Calculator
{
    public static class TestInterestCalculator
    {
        static void Main()
        {
            InterestCalculator calculateA = new InterestCalculator(500m, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine("{0:F4}", calculateA.Result);
            InterestCalculator calculateB = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine("{0:F4}", calculateB.Result);
        }
        private static decimal GetSimpleInterest(decimal amount, decimal interest, int years)
        {
            decimal result = amount * (1 + (interest / 100) * years);
            return result;
        }
        private static decimal GetCompoundInterest(decimal amount, decimal interest, int years)
        {
            decimal result = amount * (decimal)Math.Pow((double)(1 + (interest / 100) / 12), 12 * years);
            return result;
        }
    }
}