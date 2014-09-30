namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that prints all the numbers from 1 to N, that are not 
    /// divisible by 3 and 7 at the same time.
    /// </summary>
    class Divisible5_7
    {
        static void Main()
        {
            Console.Write("Input number for end of sequence (1 2 3 ... N): "); 
            int numberN = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nNumbers in sequence, not divisible by 3 and 7 at same time: ");
            string missingNumbers = string.Empty;
            for (int i = 1; i <= numberN; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    missingNumbers += i.ToString() + " ";
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n\nMissing numbers in outputed sequence: {0}", missingNumbers);
        }
    }
}