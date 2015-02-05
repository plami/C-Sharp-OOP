using System;
using System.CodeDom;

namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The width cannot be empty or null!");
                }
                this.width = value;
            }
        }

        protected double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The height cannot be empty or null!");
                }
                this.height = value;
            }
        }
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}