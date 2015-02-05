using System;

namespace _01.Point3D
{
    static class PrintPoint3D
    {
        static void Main(string[] args)
        {
            Point3D one = new Point3D(1, 1, 1);
            Console.WriteLine(one);
            Console.WriteLine(Point3D.StartingPoint3D);
        }
    }
}
