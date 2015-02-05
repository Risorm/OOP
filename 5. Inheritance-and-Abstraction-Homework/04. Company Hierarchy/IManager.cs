using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Company_Hierarchy
{
    public interface IManager
    {
        List<Employee> Employees { get; } 
    }
}
