using System;
using System.Collections.Generic;

namespace _01.School
{
    class Discipline
    {
        private static List<string> enteredIdentifiers;

        public Discipline(int numberOfLectures, List<Student> students, string details = null)
        {
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
            this.Details = details;
        }

        public Discipline(int numberOfLectures, Student student, string details = null)
            : this(numberOfLectures, new List<Student> { student }, details) { }


        public List<Student> Students { get; set; }
        public string Details { get; set; }
        public int NumberOfLectures { get; set; }
        
    }
}
