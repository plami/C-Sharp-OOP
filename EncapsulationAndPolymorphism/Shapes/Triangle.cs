using System;

namespace Shapes
{
    public class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double width, double height, double thirdSide)
            : base(width, height)
        {
            this.ThirdSide = thirdSide;
        }

        private double ThirdSide
        {
            get { return this.thirdSide; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The width cannot be empty or null!");
                }
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            var p = (this.Height + this.Width + this.thirdSide) / 2;
            var area = Math.Sqrt(p * (p - this.Height) * (p - this.Width) * (p - this.ThirdSide));
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = this.Height + this.Width + this.thirdSide;
            return perimeter;
        }
    }
}