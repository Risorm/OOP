using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teacher : Human
    {
        public Teacher(string name, List<Discipline> disciplines, string details = null)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, Discipline discipline, string details = null)
            : this(name, new List<Discipline> { discipline }, details) { }

        public List<Discipline> Disciplines { get; set; }

    }
}
