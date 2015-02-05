namespace _01.Shapes
{
    class Triangle : BasicShape
    {
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(double width, double height, double sideB, double sideC)
            : base(width, height)
        {
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public override double CalculateArea()
        {
            return ((this.Width * this.Height) / 2);
        }

        public override double CalculatePerimeter()
        {
            return (Width + SideB + SideC);
        }

        public override string ToString()
        {
            return string.Format("Triangle - {0}, SideB: {1}, SideC: {2}", base.ToString(), SideB, SideC);
        }
    }
}
