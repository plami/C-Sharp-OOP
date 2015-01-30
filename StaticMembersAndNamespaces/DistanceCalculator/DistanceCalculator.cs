using System;
using System.Collections.Generic;

namespace DistanceCalculator
{
    public class DistanceCalculator
    {
        public static double TwoPointDistance(params int[] args)
        {
            if (args.Length%2 != 0)
            {
                throw new ArgumentException("Provide even number of parameters");
            }

            List<int> pValues = new List<int>();
            List<int> qValues = new List<int>();

            for (int i = 0; i < args.Length; i++)
            {
                if (i%2 == 0)
                {
                    pValues.Add(args[i]);
                }
                else
                {
                    qValues.Add(args[i]);
                }
            }

            double squareValues = 0;
            for (int i = 0; i < qValues.Count; i++)
            {
                squareValues += Math.Pow(pValues[i] - qValues[i], 2);
            }
            return Math.Sqrt(squareValues);
        }

        private static void Main()
        {
            Console.WriteLine(DistanceCalculator.TwoPointDistance(2, 3, 4, 3, 6, 7));
        }
    }
}