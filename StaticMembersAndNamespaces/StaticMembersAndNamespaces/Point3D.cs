using System;

namespace Point3D
{
    public class Point3D
    {
        private static readonly string startingPoint = "{0, 0, 0}";

        public Point3D(string coords)
        {
            this.Coordinates = coords;
        }

        public static string StartingPoint
        {
            get { return startingPoint; }
        }

        public string Coordinates { get; set; }

        public override string ToString()
        {
            return string.Format("Coordinates: {0}", Coordinates);
        }

        private static void Main(string[] args)
        {
            Point3D p1 = new Point3D("{1, 2, 3}");
            Point3D p2 = new Point3D("{-1, 5, 3.5}");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
