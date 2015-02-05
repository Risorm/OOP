using System;

namespace _02.Distance_Calculator
{
    class Point3D
    {
        private static readonly Point3D StartPoint;

        static Point3D()
        {
            Point3D.StartPoint = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartingPoint3D
        {
            get { return Point3D.StartPoint; }
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            return String.Format("X: {0}, Y: {1}, Z: {2}", this.X, this.Y, this.Z);
        }

        public static double CalculateDistance(Point3D A, Point3D B)
        {
            return Math.Sqrt(((B.X - A.X)*(B.X - A.X)) + ((B.Y - A.Y)*(B.Y - A.Y)) + ((B.Z - A.Z) * (B.Z - A.Z)));
        }
    }
}