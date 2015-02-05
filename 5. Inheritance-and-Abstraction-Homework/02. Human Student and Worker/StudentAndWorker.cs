using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Human_Student_and_Worker
{
    static class StudentAndWorker
    {
        static void Main()
        {
            Student lucas = new Student("Lucas", "Hurst", "ahsj234");
            Student finn = new Student("Finn", "Nixon", "shdj345");
            Student joel = new Student("Joel", "Petty", "ewkj2819");
            Student brenden = new Student("Brenden", "Cataneda", "bjia123");
            Student garth = new Student("Garth", "Mathis", "sjajk12");
            Student barry = new Student("Barry", "Parsons", "cwdh182");
            Student nathan = new Student("Nathan", "Hunt", "xjakj289");
            Student ira = new Student("Ira", "Workman", "shaj2891");
            Student cain = new Student("Cain", "Oneill", "zqjwh129");
            Student tyler = new Student("Tyler", "Cummings", "hqj128");

            List<Student> students = new List<Student>()
            {
                lucas, finn, joel, brenden, garth,
                barry, nathan, ira, cain, tyler
            };

            List<Student> sortedStudents = students.OrderBy(o => o.FacultyNumber).ToList();
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Worker ivan = new Worker("Ivan", "Petrov", 7, 300m);
            Worker gosho = new Worker("Georgi", "Ivanov", 5, 789m);
            Worker pesho = new Worker("Petar", "Petrov", 4, 672m);
            Worker svilen = new Worker("Svilen", "Bismutov", 6, 3232m);
            Worker pencho = new Worker("Pencho", "Penchev", 3, 345m);
            Worker ganyo = new Worker("Ganyo", "Baev", 7, 888m);
            Worker parvolet = new Worker("Parvolet", "Nikodimov", 3, 234m);
            Worker muncho = new Worker("Muncho", "Selski", 7, 1240m);
            Worker peyo = new Worker("Peycho", "Georgiev", 2, 2738m);
            Worker stamat = new Worker("Stamat", "Stamatliev", 1, 3003m);

            List<Worker> workers = new List<Worker>()
            {
                ivan, gosho, pesho, svilen, pencho,
                ganyo, parvolet, muncho, peyo, stamat
            };
            List<Worker> sortedWorkers = workers.OrderBy(o => o.MoneyPerHour()).ToList();
            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            List<Human> allHumans = sortedWorkers.Concat<Human>(sortedStudents).ToList();
            List<Human> sortedHumans = allHumans.OrderBy(o => o.FirstName).ThenBy(o => o.LastName).ToList();
            foreach (Human human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}