using System;
using System.Collections.Generic;

namespace _01.School
{
    class School
    {
        public School(List<Class> classInstance)
        {
            this.Classes = classInstance;
        }
        public School(Class classInstance)
            : this(new List<Class> { classInstance }) { }

        public List<Class> Classes { get; set; }
    }
}
