namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// Write a program that, depending on the user's choice inputs int, double or string variable.
    /// If the variable is integer or double, increases it with 1. 
    /// If the variable is string, appends "*" at its end. 
    /// The program must show the value of that variable as a console output. Use switch statement.
    /// </summary>
    class Task8
    {
        static void Main()
        {
            Console.WriteLine("For integer press 1");
            Console.WriteLine("For double press 2");
            Console.WriteLine("For string press 3");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (number)
            {
                case 1:
                    Console.Write("Input integer "); 
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
                case 2:
                    Console.Write("Input double type number "); 
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine((d + 1).ToString());
                    break;
                case 3:
                    Console.Write("Input string "); 
                    string input = Console.ReadLine();
                    Console.WriteLine(input + "*");
                    break;
                default:
                    break;
            }
        }
    }
}