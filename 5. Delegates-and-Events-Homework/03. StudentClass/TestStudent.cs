namespace _03.StudentClass
{
    public class TestStudent
    {
        static void Main()
        {
            var student = new Student("Pesho", 11);
            student.Name = "Pena";
            student.Age = 10;
            student.Name = "Hulio";
            student.Age = 13;
        } 
    }
}