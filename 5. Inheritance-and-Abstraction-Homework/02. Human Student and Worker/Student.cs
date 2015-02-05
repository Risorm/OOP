using System;
using System.Text.RegularExpressions;

namespace _02.Human_Student_and_Worker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                Regex pattern = new Regex(@"[^a-zA-Z0-9]");
                Match match = pattern.Match(value);
                if (match.Success)
                {
                    throw new ArgumentException("Faculty number can contain only numbers and letters.");
                }
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faculty number must be between 5 and 10 symbols of length.");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Student - First Name: {0}; Last Name: {1}; Faculty Number: {2}",
                this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
