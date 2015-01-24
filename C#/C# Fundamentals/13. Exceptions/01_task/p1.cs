/*
 * Write a program that reads an integer number and calculates and
 * prints its square root. If the number is invalid or negative,
 * print "Invalid number". In all cases finally print "Good bye"
 */

namespace TAonlineHomework7exceptions
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentNullException argEx)
            {
                ExceptionProcessor(argEx);
            }
            catch (FormatException fe)
            {
                ExceptionProcessor(fe);
            }
            catch (OverflowException oe)
            {
                ExceptionProcessor(oe);
            }
            finally
            {
                Console.WriteLine();
            }

        }

        private static void ExceptionProcessor(Exception message)
        {
            Console.WriteLine(message);
        }
    }
}
