namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;
    using System.Linq;

    /// <summary>
    /// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
    /// of given 32-bit unsigned integer
    /// </summary>
    class Task13
    {
        static void Main()
        {
            int number;
            int nearBit, farBit, bitSequenceLenght;

            Console.Write("Enter an positive integer number (0-255):"); 
            number = int.Parse(Console.ReadLine());
            Console.Write("Enter the near bit position: "); 
            nearBit = int.Parse(Console.ReadLine());
            Console.Write("Enter the far bit position: "); 
            farBit = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of sequence of bits: "); 
            bitSequenceLenght = int.Parse(Console.ReadLine());

            //This solution use string  and string methods. Bitwise operations in next project (14)

            //Convert to binary string and fill '0' for rest positions to 32;
            string binaryString = Convert.ToString(number, 2).PadLeft(32, '0');

            int len = binaryString.Length - 1;

            char[] chars = binaryString.ToCharArray();
            char[] chars2 = binaryString.ToCharArray();

            for (int i = 0; i < bitSequenceLenght; i++)
            {
                chars[len - nearBit - i] = chars2[len - farBit - i]; //exchange values between oposite positions;
                chars[len - farBit - i] = chars2[len - nearBit - i];
            }

            //TODO: reverse convertion (char => decimal)
            Console.WriteLine(binaryString);
            Console.WriteLine(chars);
        }
    }
}