namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        protected BasicShape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        protected double Width { get; private set; }
        protected double Height { get; private set; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return string.Format("Width: {0}, Height: {1}", Width, Height);
        }
    }
}
