using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Hierarchy
{
    class Customer:Person
    {
        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmmount) : base(id, firstName, lastName)
        {
            this.NetPurchaseAmmount = netPurchaseAmmount;
        }

        public decimal NetPurchaseAmmount { get; set; }
    }
}
