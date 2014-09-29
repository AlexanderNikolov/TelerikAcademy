namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write a boolean expression that returns if the bit at position p (counting from 0)
    /// in a given integer number v has value of 1. Example: v=5; p=1  false.
    /// </summary>
    class BitPositionValue
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: "); 
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position (from 0): "); 
            int p = int.Parse(Console.ReadLine());

            //output
            Console.Write("v={0}  p={1}   ", v, p);
            Console.WriteLine(isBitValue(v, p));
        }

        /// <summary>
        /// helper function (number, bit position) => boolean
        /// </summary>
        /// <param name="number">integer</param>
        /// <param name="bitPosition">integer, represent position of bit in number</param>
        /// <returns>true or false depend value of bit in position</returns>
        static bool isBitValue(int number, int bitPosition)
        {
            int mask = (int)(1 << bitPosition);

            if ((number & mask) == mask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}