using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Hierarchy
{
    class Developer : RegularEmployee
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Department department, List<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public Developer(int id, string firstName, string lastName, decimal salary, Department department, Project project)
            : this(id, firstName, lastName, salary, department, new List<Project>() { project }) { }

        public List<Project> Projects { get; set; }
    }
}
