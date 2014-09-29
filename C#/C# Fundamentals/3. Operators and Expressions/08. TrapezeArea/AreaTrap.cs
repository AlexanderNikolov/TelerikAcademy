namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Find area of trapeze if have sides a, b and hight h
    /// </summary>
    class Task8
    {
        static void Main()
        {
            var sideA = 4;
            var sideB = 2;
            var hight = 3;
            var trapezeArea = (0.5 * (sideA + sideB)) * hight;

            Console.WriteLine("Area of trapeze with a={0}, b={1}, h={2} is: {3}", sideA, sideB, hight, trapezeArea);
        }
    }
}