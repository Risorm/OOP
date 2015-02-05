using System;

namespace _02.Bank_of_Kurtovo_Konare
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(decimal balance, CustomerType customer, double interestRate, DateTime openingDate)
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
            if (this.Customer == CustomerType.Company && monthsSinceOpened < 2)
            {
                months -= (2 - monthsSinceOpened);
                return base.CalculateInterest(months);
            }
            else if (this.Customer == CustomerType.Individual && monthsSinceOpened < 3)
            {
                months -= (3 - monthsSinceOpened);
                return base.CalculateInterest(months);
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
