using System;

namespace _02.Bank_of_Kurtovo_Konare
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(decimal balance, CustomerType customer, double interestRate, DateTime openingDate)
            : base(balance, customer, interestRate, openingDate)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            DateTime now = DateTime.Now;
            int monthsSinceOpened = ((now.Year - OpeningDate.Year) * 12) + now.Month - OpeningDate.Month;
            if (this.Customer == CustomerType.Company && monthsSinceOpened < 12)
            {
                return (base.CalculateInterest(months) / 2);
            }
            else if (this.Customer == CustomerType.Individual && monthsSinceOpened < 6)
            {
                return (base.CalculateInterest(months) / 2);
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
