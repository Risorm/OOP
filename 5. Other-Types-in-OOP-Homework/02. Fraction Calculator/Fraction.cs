using System;

namespace _02.Fraction_Calculator
{
    struct Fraction
    {
        private decimal denominator;

        public Fraction(int numerator, int denominator)
            : this()
        {
            this.Denominator = (decimal)denominator;
            Numerator = (decimal)numerator;
        }

        public decimal Numerator { get; set; }

        public decimal Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be less than 0!");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {

            Fraction fraction = new Fraction();
            fraction.Numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            fraction.Denominator = a.Denominator * b.Denominator;
            return fraction;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {

            Fraction fraction = new Fraction();
            fraction.Numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            fraction.Denominator = a.Denominator * b.Denominator;
            return fraction;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Numerator/this.Denominator);
        }
    }
}
