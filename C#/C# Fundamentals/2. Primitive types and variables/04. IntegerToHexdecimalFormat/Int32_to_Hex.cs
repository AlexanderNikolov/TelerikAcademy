namespace TAonline.CSharp.PrimitiveTypesAndVariables.Homework2
{
    using System;

    /// <summary>
    /// Assign to var a number 254 in hexadecimal format
    /// </summary>
    class Task4
    {
        static void Main()
        {
            int number = 254;
            string hexFormat = number.ToString("X");
            Console.WriteLine("254 in hexdecimalformat: {0}", hexFormat);
        }
    }
}