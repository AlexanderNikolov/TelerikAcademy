/*
 * Write methods that calculate the surface of a triangle by given:
 * -Side and an altitude to it;
 * -Three sides;
 * -Two sides and an angle between them.
 */

namespace TA2014_homework_classes
{
    using System;
    using System.Linq;

    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:F2}", TriangleSurfaceCalc(12, 5, 0, 1));
            Console.WriteLine("{0:F2}", TriangleSurfaceCalc(12, 12, 12, 2));
            Console.WriteLine("{0:F2}", TriangleSurfaceCalc(12, 5, ToRadians(30), 3));
        }

        static double TriangleSurfaceCalc(double x, double y, double z, int key)
        {
            double surface = double.MinValue;

            if (key == 1) return surface = x * y / 2;
            else if (key == 2)
            {
                double p = (x + y + z) / 2.0;  //p == perimeter, (Heron's formula)
                return surface = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            }
            else if (key == 3)
            {
                double c = Math.Sqrt(x * x + y * y - 2 * x * y * Math.Cos(z));
                double p = (x + y + c) / 2;
                return surface = Math.Sqrt(p * (p - x) * (p - y) * (p - c));
            }
            else
                throw new ArgumentException();
        }

        static double ToRadians(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }
    }
}
