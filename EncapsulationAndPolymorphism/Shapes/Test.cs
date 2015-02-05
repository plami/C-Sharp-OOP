using System;

namespace Shapes
{
    class Test
    {
        static void Main()
        {
            IShape triangle1 = new Triangle(2.5, 2, 60);
            IShape triangle2 = new Triangle(3.1, 2.1, 90);

            IShape rect1 = new Rectangle(2.5, 2);
            IShape rect2 = new Rectangle(3.1, 2.1);

            IShape circle1 = new Circle(2.5);
            IShape circle2 = new Circle(2.1);

            IShape[] shapes = new IShape[6] { triangle1, triangle2, rect1, rect2, circle1, circle2 };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}: Perimeter: {1:N2}, Area: {2:N2}", shape.GetType().Name, shape.CalculatePerimeter(), shape.CalculateArea());
            }
        }
    }
}
