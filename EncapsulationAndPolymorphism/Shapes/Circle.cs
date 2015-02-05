using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        protected double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The radius cannot be empty or null!");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}