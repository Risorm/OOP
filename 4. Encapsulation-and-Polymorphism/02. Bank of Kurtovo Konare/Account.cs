using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    abstract class Account : IAccountable
    {
        public Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public override string ToString()
        {
            return string.Format("Customer: {0}, Balance: {1}, InterestRate: {2}", Customer, Balance, InterestRate);
        }
    }
}
