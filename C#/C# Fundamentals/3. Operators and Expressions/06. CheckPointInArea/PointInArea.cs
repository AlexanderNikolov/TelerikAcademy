namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write an expression that checks if given point (x,  y) is within a circle K(O, 5);
    /// </summary>
    class Task6
    {
        static void Main()
        {
            const int RADIUS = 5;

            Console.Write("Enter value for x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter value for y: ");
            int y = int.Parse(Console.ReadLine());

            if ((-RADIUS <= x) && (x <= RADIUS) &&
                (-RADIUS <= y) && (y <= RADIUS))
            {
                Console.WriteLine("(x, y) is within circle area");
            }
            else
            {
                Console.WriteLine("(x, y) is out of circle area");
            }
        }
    }
}