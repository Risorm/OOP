using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    abstract class Account
    {
        protected Account(decimal balance, CustomerType customer, double interestRate, DateTime openingDate)
        {
            this.Balance = balance;
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.OpeningDate = openingDate;
        }

        public CustomerType Customer { get; private set; }

        public decimal Balance { get; protected set; }

        public double InterestRate { get; private set; }

        public DateTime OpeningDate { get; private set; }

        public virtual decimal CalculateInterest(int months)
        {
            decimal futureBalance = this.Balance * (decimal)(1 + (this.InterestRate * months));
            return futureBalance;
        }

        public override string ToString()
        {
            return string.Format("Customer: {0}, Balance: {1}, InterestRate: {2}", Customer, Balance, InterestRate);
        }
    }
}
