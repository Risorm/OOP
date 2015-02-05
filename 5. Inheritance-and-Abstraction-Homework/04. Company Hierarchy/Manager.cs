using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Hierarchy
{
    class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department,
            List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public Manager(int id, string firstName, string lastName, decimal salary, Department department,
    Employee employee)
            : this(id, firstName, lastName, salary, department, new List<Employee> { employee }) { }

        public List<Employee> Employees { get; set; }

    }
}
