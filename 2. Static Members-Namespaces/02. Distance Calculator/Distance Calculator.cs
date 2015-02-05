using System; 

namespace _02.Distance_Calculator
{
    static class Distance_Calculator
    {
        static void Main(string[] args)
        {
            Point3D pointA = new Point3D(2, 3, 5);
            Point3D pointB = new Point3D(1, 10, 55);
            double distance = Point3D.CalculateDistance(pointA, pointB);
            Console.WriteLine("The distance between A and B is {0:##.##}", distance);
        }
    }
}