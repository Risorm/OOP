using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Hierarchy
{
    public class Employee : Person, IEmployee
    {
        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public decimal Salary { get; set; }


        public Department Department { get; set; }
    }
}
