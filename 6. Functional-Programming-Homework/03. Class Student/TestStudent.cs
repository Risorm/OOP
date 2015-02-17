using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Class_Student
{
    class TestStudent
    {
        static void Main()
        {

            List<Student> students = new List<Student>
        {
            new Student ("Pesho","Peshev",10,372, "02843298", "pesho@mail.bg", new List<int>(){3,4},2),
            new Student ("Gosho","Goshev",10,464, "+3592823728", "gosho@mail.bg", new List<int>(){6,6,4},2),
            new Student ("Penko","Arnaudov",32,323, "+83293823", "penko@abv.bg", new List<int>(){4,2,1},12),
            new Student("Branden", "Cortez", 29, 40214, "(111) 858-3635", "sagittis@ultriciesdignissimlacus.com", new List<int>(){2,2,3},12),
            new Student("Aleksi", "Stavrev", 19, 40114, "(111) 858-3456", "aleksi@ultriciesdignissimlacus.com", new List<int>(){2,2,6},12),
        };
            Console.WriteLine("\n\r------------Problem 4:----------");
            var sortedFirstName = from student in students where student.GroupNumber == 2 orderby student.FirstName select student;
            foreach (var student in sortedFirstName)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 5:----------");
            var sortedFirstNameAndLastName = from student in students where student.FirstName.CompareTo(student.LastName) < 0 select student;
            foreach (var student in sortedFirstNameAndLastName)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 6:----------");
            var sortedAge = from student in students
                            where student.Age >= 18 && student.Age <= 24
                            select new { student.FirstName, student.LastName, student.Age };
            foreach (var student in sortedAge)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 7 - Lambda:----------");
            var sortedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 7 - LINQ:-----------");
            var sortedStudentsAlt = from student in students
                                    orderby student.FirstName descending, student.LastName descending
                                    select student;

            foreach (var student in sortedStudentsAlt)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 8:---------");
            var sortedByABV = from student in students
                              where student.Email.Contains("@abv.bg")
                              select student;

            foreach (var student in sortedByABV)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 9:---------");
            var sortedBySofiaPhone = from student in students
                                     where student.Phone.StartsWith("02") ||
                                     student.Phone.StartsWith("+3592") ||
                                     student.Phone.StartsWith("+359 2")
                                     select student;

            foreach (var student in sortedBySofiaPhone)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\r------------Problem 10:---------");
            var allExcellentMarks = from student in students
                            where student.Marks.Contains(6)
                            select new { FullName = student.FirstName + " " + student.LastName, student.Marks };
            Console.WriteLine("\n\rStudents with excellent marks: ");
            foreach (var student in allExcellentMarks)
            {
                Console.WriteLine("{0} - {1} ", student.FullName, string.Join(", ", student.Marks));
            }


            Console.WriteLine("\n\r------------Problem 11:---------");
            var exactlyTwoMarks = from student in students
                                    where student.Marks.Count() == 2
                                    select new { FullName = student.FirstName + " " + student.LastName, student.Marks };
            Console.WriteLine("\n\rStudents with two marks: ");
            foreach (var student in exactlyTwoMarks)
            {
                Console.WriteLine("{0} - {1} ", student.FullName, string.Join(", ", student.Marks));
            }

                        Console.WriteLine("\n\r------------Problem 12:---------");
            var enrolledIn2014 = from student in students
                where student.FacultyNumber % 100 == 14
                select student;
            foreach (var student in enrolledIn2014)
            {
                Console.WriteLine(student);
            }

        }
    }
}