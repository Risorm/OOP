using System;

namespace _01.Shapes
{
    class Circle : IShape
    {
        private const double Pi = Math.PI;

        public Circle(double r)
        {
            this.Radius = r;
        }

        private double Radius { get; set; }

        public double CalculateArea()
        {
            return (Pi * Radius * Radius);
        }

        public double CalculatePerimeter()
        {
            return (2 * Pi * Radius);
        }

        public override string ToString()
        {
            return string.Format("Circle - Radius: {0}", Radius);
        }
    }
}
