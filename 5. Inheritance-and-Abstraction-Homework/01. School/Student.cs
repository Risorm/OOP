using System;
using System.Collections.Generic;

namespace _01.School
{
    class Student : Human
    {
        private static List<int?> enteredClassNumbers;
        private int? classNumber;

        static Student()
        {
            Student.enteredClassNumbers = new List<int?>();
        }

        public Student(string name, int classNumber, string details = null)
            : base(name, details)
        {
            this.ClassNumber = classNumber;
            Student.enteredClassNumbers.Add(classNumber);
        }

        public int? ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid class number!");
                }
                if (enteredClassNumbers.Contains(value))
                {
                    throw new ArgumentException("This class number is already in use.");
                }
                this.classNumber = value;
            }
        }
    }
}
