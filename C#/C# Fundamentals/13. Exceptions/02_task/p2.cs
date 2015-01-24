/*
 * Write a method ReadNumber(int start, int end) that enters an integer 
 * number in given range [start…end]. If an invalid number or non-number 
 * text is entered, the method should throw an exception. Using this 
 * method write a program that enters 10 numbers:
 *      a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

namespace _TAonlineHomework7exceptions
{
    using System;
    using System.Linq;

    class ReadNumberProgram
    {
        static void Main()
        {
            int start = 1;
            int end = 100;

            try
            {
                for (int i = start; i < end; i += 10)
                {
                    Console.Write("Input 10 numbers ( 1<n<100 ) ");
                    int number = int.Parse(Console.ReadLine());
                    if (number <= start || number >= end) 
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException aor)
            {
                ExceptionProcessor(aor);
            }
            catch (FormatException fe)
            {
                ExceptionProcessor(fe);
            }
        }

        private static void ExceptionProcessor (Exception message)
        {
            //TODO Exception message filter
            Console.WriteLine(message);
        }
    }
}
