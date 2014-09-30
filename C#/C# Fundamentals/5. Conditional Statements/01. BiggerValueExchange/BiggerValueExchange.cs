namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// Write an if statement that examines two integer variables and exchanges their values
    /// if the first one is greater than the second one.
    /// </summary>
    class Task1
    {
        static void Main()
        {
            Console.Write("Enter integer number"); 
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter lower integer number"); 
            int numB = int.Parse(Console.ReadLine());

            if (numA > numB)
            {
                int tempValue = numA;
                numA = numB;
                numB = tempValue;
                Console.WriteLine("Exchange successful! Now first = {0} second = {1}", numA, numB);
            }
        }
    }
}