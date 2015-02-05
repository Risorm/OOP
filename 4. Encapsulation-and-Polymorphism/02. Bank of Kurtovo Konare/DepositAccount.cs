using System;

namespace _02.Bank_of_Kurtovo_Konare
{
    class DepositAccount : Account, IAccountable, IDepositable
    {
        public DepositAccount(decimal balance, CustomerType customer, double interestRate, DateTime openingDate)
            : base(balance, customer, interestRate, openingDate)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 1000)
            {
                return base.CalculateInterest(months);
            }
            else
            {
                return 0;
            }
        }
    }
}
