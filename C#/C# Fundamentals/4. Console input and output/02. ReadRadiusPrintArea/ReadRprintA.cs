namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program that reads the radius r of a circle and prints its perimeter and area;
    /// </summary>
    class Task2
    {
        static void Main(string[] args)
        {
            const double PI = 3.1428;

            Console.Write("Enter radius of circle: ");
            int circleRadius = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("With radius {0}, circle perimeter = {1} and circle area = {2} ",
                circleRadius, (2 * circleRadius * PI), (circleRadius * circleRadius * PI));
        }
    }
}