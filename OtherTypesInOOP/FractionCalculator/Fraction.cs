using System;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentOutOfRangeException("Invalid numerator!");
                }
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The denominator cannot be zero!");
                }
                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentOutOfRangeException("Invalid denominator!");
                }
                this.denominator = value;
            }
        }
        //overload of the built-in operator to perform addition 
        public static Fraction operator +(Fraction first, Fraction second)
        {
            long numerator, denominator;
            numerator = first.Numerator * second.Denominator + first.Denominator * second.Numerator;
            denominator = first.Denominator * second.Denominator;
            Fraction result = new Fraction(numerator, denominator);

            return result;
        }
        //overload of the built-in operator to perform substraction 
        public static Fraction operator -(Fraction first, Fraction second)
        {
            long numerator, denominator;
            numerator = first.Numerator * second.Denominator - first.Denominator * second.Numerator;
            denominator = first.Denominator * second.Denominator;
            Fraction result = new Fraction(numerator, denominator);

            return result;
        }

        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;
            return result.ToString();
        }
    }
}