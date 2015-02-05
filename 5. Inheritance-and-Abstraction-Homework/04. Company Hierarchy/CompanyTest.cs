using System;
using System.Collections.Generic;

namespace _04.Company_Hierarchy
{
    internal class CompanyTest
    {
        private static void Main(string[] args)
        {
            Sale laptop = new Sale("Lenovo", new DateTime(2013, 12, 1), 432m);
            Sale chair = new Sale("Ronos", new DateTime(2012, 11, 12), 300m);
            SalesEmployee ivan = new SalesEmployee(23, "Ivan", "Georgiev", 234m, Department.Accounting, chair);
            SalesEmployee gosho = new SalesEmployee(21, "Georgi", "Peev", 250m, Department.Marketing, laptop);
            Project laptops = new Project("Lenovo", new DateTime(2013, 11, 10), "bla-bla");
            Project chairs = new Project("ludnica.bg", new DateTime(2015, 10, 10), "detail");
            chairs.CloseProject();
            Developer pencho = new Developer(11, "Pencho", "Penchev", 200m, Department.Production, chairs);
            Developer stamat = new Developer(14, "Stamat", "Stamatov", 1000m, Department.Production, laptops);
            Manager tenyo = new Manager(34, "Tenyo", "Tenev", 300m, Department.Marketing, pencho);
            Manager gerasim = new Manager(91, "Gerasim", "Genov", 1000m, Department.Marketing, new List<Employee>() { stamat, pencho });

            var employees = new List<IPerson>();
            employees.Add(ivan);
            employees.Add(pencho);
            employees.Add(gosho);
            employees.Add(stamat);
            employees.Add(tenyo);
            employees.Add(gerasim);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }
        }
    }
}
