namespace TAonline.CSharp.PrimitiveTypesAndVariables.Homework2
{
    using System;

    /// <summary>
    /// Write a program for drawing a isosceles triangle from 9 (copyright) simbols
    /// memo: copyright simbol in Unicode table is '\u00A9'
    /// </summary>
    class Task9
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int count = 1;
            
            for (int i = 1; i <= rows; i++, count += 2)
            {
                Console.Write(new string(' ', rows - i)); 
                Console.WriteLine(new string('\u00A9', count));
            }
            
            Console.WriteLine();
        }
    }
}