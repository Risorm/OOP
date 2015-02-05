using System;

namespace _01.Shapes
{
    static class TestShapes
    {
        static void Main()
        {
            var firstTriangle = new Triangle(2, 1.4, 2.4, 2);
            var secondTriangle = new Triangle(5, 5.4, 12.4, 9);
            var firstRectangle = new Rectangle(5.2, 3.5);
            var secondRectangle = new Rectangle(10, 32.5);
            var firstCircle = new Circle(5);
            var secondCircle = new Circle(12.3);

            var shapes = new IShape[]
            {
                firstTriangle, secondTriangle, firstRectangle, secondRectangle, firstCircle, secondCircle
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}\n\rArea: {1:##.###} Perimeter {2:##.###}\n\r",
                    shape, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}