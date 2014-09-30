namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that finds the greatest of given 5 variables.
    /// </summary>
    class Task7
    {
        static void Main()
        {
            int[] arr = new int[5];

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Enter number {0} from 5  ", i); 
                int number = int.Parse(Console.ReadLine());
                arr[i - 1] = number;
            }

            int max = arr.Max();
            Console.WriteLine(max);
        }
    }
}