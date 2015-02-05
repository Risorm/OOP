using System;


namespace _01.School
{
    class TestSchool
    {
        static void Main(string[] args)
        {
            //Only some classes initialied to check if program compiles. Per problem deffinition no further action required.
            Student pesho = new Student("Pesho", 10, "idiot");
            Discipline swimming = new Discipline(4, pesho);
            Teacher gosho = new Teacher("Gosho",swimming);
            Class fourthClass = new Class("4B", gosho);
            School highSchool = new School(fourthClass);
        }
    }
}
