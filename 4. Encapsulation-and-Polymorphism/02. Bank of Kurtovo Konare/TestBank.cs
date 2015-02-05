using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_of_Kurtovo_Konare
{
    static class TestBank
    {
        static void Main(string[] args)
        {
            LoanAccount peshoLoan = new LoanAccount(-200m, CustomerType.Individual, 3.3, new DateTime(2015, 1, 10));
            Console.WriteLine(peshoLoan);
            peshoLoan.Deposit(100m);
            Console.WriteLine(peshoLoan);
            Console.WriteLine(peshoLoan.CalculateInterest(3));

            LoanAccount goshoLoan = new LoanAccount(-200m, CustomerType.Individual, 3.3, new DateTime(2014, 10, 10));
            Console.WriteLine(goshoLoan);
            goshoLoan.Deposit(100m);
            Console.WriteLine(goshoLoan);
            Console.WriteLine(goshoLoan.CalculateInterest(3));

            LoanAccount microsoftLoan = new LoanAccount(-1000000m, CustomerType.Company, 3.3, new DateTime(2015, 1, 10));
            Console.WriteLine(microsoftLoan);
            microsoftLoan.Deposit(20000m);
            Console.WriteLine(microsoftLoan);
            Console.WriteLine(microsoftLoan.CalculateInterest(3));

            MortgageAccount peshoMortgageAccount = new MortgageAccount(-200m, CustomerType.Individual, 3.3, new DateTime(2014, 1, 10));
            Console.WriteLine(peshoMortgageAccount);
            peshoMortgageAccount.Deposit(100m);
            Console.WriteLine(peshoMortgageAccount);
            Console.WriteLine(peshoMortgageAccount.CalculateInterest(3));

            MortgageAccount goshoMortgageAccount = new MortgageAccount(-200m, CustomerType.Individual, 3.3, new DateTime(2014, 10, 10));
            Console.WriteLine(goshoMortgageAccount);
            goshoMortgageAccount.Deposit(100m);
            Console.WriteLine(goshoMortgageAccount);
            Console.WriteLine(goshoMortgageAccount.CalculateInterest(3));

            MortgageAccount microsoftMortgageAccount = new MortgageAccount(-1000000m, CustomerType.Company, 3.3, new DateTime(2014, 1, 10));
            Console.WriteLine(microsoftMortgageAccount);
            microsoftMortgageAccount.Deposit(20000m);
            Console.WriteLine(microsoftMortgageAccount);
            Console.WriteLine(microsoftMortgageAccount.CalculateInterest(3));

            DepositAccount peshoDepositAccount = new DepositAccount(200m, CustomerType.Individual, 6.3, new DateTime(2011, 1, 10));
            Console.WriteLine(peshoDepositAccount);
            peshoDepositAccount.Deposit(100m);
            Console.WriteLine(peshoDepositAccount);
            peshoDepositAccount.Withdraw(50m);
            Console.WriteLine(peshoDepositAccount);
            Console.WriteLine(peshoDepositAccount.CalculateInterest(3));

            DepositAccount goshoDepositAccount = new DepositAccount(1000, CustomerType.Individual, 6.3, new DateTime(2013, 1, 10));
            Console.WriteLine(goshoDepositAccount);
            goshoDepositAccount.Deposit(100m);
            Console.WriteLine(goshoDepositAccount);
            goshoDepositAccount.Withdraw(50m);
            Console.WriteLine(goshoDepositAccount);
            Console.WriteLine(goshoDepositAccount.CalculateInterest(10));

            DepositAccount microsoftDepositAccount = new DepositAccount(2000, CustomerType.Company, 6.3, new DateTime(2011, 1, 10));
            Console.WriteLine(microsoftDepositAccount);
            microsoftDepositAccount.Deposit(100m);
            Console.WriteLine(microsoftDepositAccount);
            microsoftDepositAccount.Withdraw(50m);
            Console.WriteLine(microsoftDepositAccount);
            Console.WriteLine(microsoftDepositAccount.CalculateInterest(5));
        }
    }
}
