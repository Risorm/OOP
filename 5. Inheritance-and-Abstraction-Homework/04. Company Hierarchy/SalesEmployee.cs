using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Hierarchy
{
    class SalesEmployee : RegularEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, Sale sale)
            : this(id, firstName, lastName, salary, department, new List<Sale>() { sale }) { }

        public List<Sale> Sales { get; set; }
    }
}
