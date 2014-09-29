namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
    /// </summary>
    class Task7
    {
        static void Main()
        {
            Console.Write("Enter sequence length "); 
            int len = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= len; i++)
            {
                Console.Write("Enter number {0} : ", i); 
                int a = int.Parse(Console.ReadLine());
                sum += a;
            }

            Console.WriteLine("Sum of numbers is: {0}", sum);
        }
    }
}