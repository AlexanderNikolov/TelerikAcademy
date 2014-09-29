namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Exercise 14: Write a program that exchanges bits {p, p+1, …, p+k-1)
    /// with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer;
    /// </summary>
    class Task14
    {
        static void Main()
        {
            int number = 0;
            int startBit, farBit, bitSequenceLenght;
            string binaryString, binaryString2;

            Console.Write("Enter an positive integer number (0-256):"); 
            number = int.Parse(Console.ReadLine());
            Console.Write("Enter the starting bit: "); 
            startBit = int.Parse(Console.ReadLine());
            Console.Write("Enter the starting far bit: "); 
            farBit = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of sequence of bits: "); 
            bitSequenceLenght = int.Parse(Console.ReadLine());

            Console.WriteLine(number);    

            binaryString = 
                Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine(binaryString);  
            Console.WriteLine(Convert.ToString(ExchangeBitSeq(number, startBit, farBit, bitSequenceLenght)));

            binaryString2 = 
                Convert.ToString(ExchangeBitSeq(number, startBit, farBit, bitSequenceLenght), 2)
                       .PadLeft(32, '0');
            Console.WriteLine(binaryString2);
        }

        /// <summary>
        /// helper function (bitwise operations)
        /// (special thaks to vladO for clear explanation of bitwise operations);
        /// </summary>
        static int ExchangeBitSeq(int number, int startBit, int farBit, int bitSequenceLenght)
        {
            int baseMask = (1 << bitSequenceLenght) - 1; //additional mask needed for sequence of bits (k > 1)!
            int xMask = (baseMask << startBit); //shifted by x positions left
            int yMask = (baseMask << farBit);

            int closeValue = (number & xMask); //take bit value from position
            int farValue = (number & yMask);

            closeValue = closeValue >> startBit; //store bit value at position 1 (right)
            farValue = farValue >> farBit;

            number = (number & (~xMask));
            number = (number & (~yMask));

            closeValue = (closeValue << farBit); //exchange value of bits on given positions 
            farValue = (farValue << startBit);

            number = (number | closeValue);
            number = (number | farValue);

            return number;
        }
    }
}

