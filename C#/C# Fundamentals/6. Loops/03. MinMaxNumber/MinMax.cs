namespace TAonline.CSharp.Loops.Homework
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that reads from the console a sequence of N integer numbers and returns
    /// the minimal and maximal of them.
    /// </summary>
    class Task3
    {
        static void Main()
        {
            Console.Write("Input number for end of sequence (1-9):  "); 
            int numberN = int.Parse(Console.ReadLine());

            int min, max;
            int[] numbers = new int[numberN];

            Console.Clear();
            for (int i = 0; i < numberN; i++)
            {
                Console.Write("Input random integer number ({0} from {1})  ", i + 1, numberN);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            min = numbers.Min();
            max = numbers.Max();

            Console.WriteLine("\nMin of this numbers is {0}", min);
            Console.WriteLine("Max of this numbers is {0}", max);
        }
    }
}