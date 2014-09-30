namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// Write a program that enters the coefficients a, b and c of a quadratic equation
    /// a.x^2 + b.x + c = 0 and calculates and prints its real roots.
    /// Note that quadratic equations may have 0, 1 or 2 real roots.
    /// </summary>
    class QuadraticFormula
    {
        static void Main()
        {
            Console.Write("Enter coefficient a of quadratic equation a.x^2+b.x+c=0 "); 
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b of quadratic equation a.x^2+b.x+c=0 "); 
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c of quadratic equation a.x^2+b.x+c=0 "); 
            int c = int.Parse(Console.ReadLine());

            int delta = ((b * b) - (4 * a * c));

            if (delta > 0)
            {
                int x1 = (int)((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                int x2 = (int)((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));

                Console.WriteLine("Roots of quadratic equation ax2+bx+c=0 are: \nx1 = {0} \nx2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                int x = -b / (2 * a);
                Console.WriteLine("Root of quadratic equation ax2+bx+c=0 is: \nx = {0}", x);
            }
            else
            {
                Console.WriteLine("This quadratic equation have not roots");
            }
        }
    }
}