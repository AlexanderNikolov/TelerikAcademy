namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Check point (x, y) is member of area of circle K(0, 5) && area of rectangle(1, -1, 6, 2)
    /// </summary>
    class PointInArea2
    {
        static void Main()
        {
            int x = 0;
            int y = 0;

            Console.Write("Enter position x of point");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter position y of point");
            y = int.Parse(Console.ReadLine());

            if ((-1 <= x) && (x <= 2) &&
                (-1 <= y) && (y <= 1) &&
                (x*x + y*y) <= 25 )
            {
                Console.WriteLine("({0}, {1}) is within rectangle and circle areas", x, y);
            }
            else
            {
                Console.WriteLine("({0}, {1}) is out of rectangle area", x, y);
            }
        }
    }
}