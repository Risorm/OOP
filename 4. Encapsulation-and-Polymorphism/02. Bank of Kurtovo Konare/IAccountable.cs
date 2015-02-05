using System;

namespace _02.Bank_of_Kurtovo_Konare
{
    public interface IAccountable
    {
        CustomerType Customer { get; }
        decimal Balance { get; }
        double InterestRate { get; }
        DateTime OpeningDate { get; }
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        decimal CalculateInterest(int months);
    }
}