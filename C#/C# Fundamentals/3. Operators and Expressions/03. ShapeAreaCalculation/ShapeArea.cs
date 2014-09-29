namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write an expression that calculates rectangle’s area by given width and height.");
    /// </summary>
    class Task3
    {
        static void Main()
        {
            Console.Write("Enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("\nEnter rectangle height: ");
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = (width * height);
            Console.WriteLine("Area of rectangle is: {0}", rectangleArea);
        }
    }
}