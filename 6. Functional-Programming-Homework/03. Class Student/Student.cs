/*Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Class_Student
{
    class Student
    {

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, List<int> marks, int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FacultyNumber = facultyNumber;
            Phone = phone;
            Email = email;
            Marks = marks;
            GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("FirstName: {0}, LastName: {1}, Age: {2}, FacultyNumber: {3}, Phone: {4}, Email: {5}, Marks: {6}, GroupNumber: {7}", FirstName, LastName, Age, FacultyNumber, Phone, Email, string.Join(",", Marks), GroupNumber);
        }
    }
}
