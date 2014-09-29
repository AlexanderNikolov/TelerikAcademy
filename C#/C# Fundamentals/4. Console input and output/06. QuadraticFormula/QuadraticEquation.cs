namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program that reads the coefficients a, b and c of a quadratic equation a.x^2 + b.x + c = 0
    /// and solves it (prints its real roots);
    /// </summary>
    class Task6
    {
        static void Main()
        {
            Console.Write("Enter coefficient a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient c: "); double c = double.Parse(Console.ReadLine());

            double root1 = 0;
            double root2 = 0;
            double delta = (b * b - 4 * (a * c));
            Console.WriteLine();

            if (delta == 0)
            {
                root1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                Console.WriteLine("x = {0:0}", root1);
            }
            else if (delta > 0)
            {
                root1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                root2 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                Console.WriteLine("x1 = {0:0.00}\nx2 = {1:0.00}", root1, root2);
            }
            else
            {
                Console.WriteLine("With this coefficients equation have complex numbers for roots");
            }
        }
    }
}