using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fraction_Calculator
{
    struct Fraction
    {
        private int denominator;

        public Fraction(int denominator, int numerator) : this()
        {
            this.Denominator = denominator;
            Numerator = numerator;
        }

        public int Numerator { get; set; }

        public int Denominator
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

        public static Fraction operator +(Fraction a, Fraction b)
        {

            Fraction fraction = new Fraction();
            fraction.denominator = 
        }
    }
}
