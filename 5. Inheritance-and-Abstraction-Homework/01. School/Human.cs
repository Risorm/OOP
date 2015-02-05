using System;

namespace _01.School
{
    abstract class Human
    {
        public Human(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }

        public string Details { get; set; }
        public string Name { get; set; }
    }
}