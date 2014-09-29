namespace TAonline.CSharp.PrimitiveTypesAndVariables.Homework2
{
    using System;

    /// <summary>
    /// Print ASCII table
    /// </summary>
    class Task12
    {
        static void Main()
        {
            for (byte i = 1; i < 128; i++)
            {
                Console.WriteLine(" {0}: {1}", i, (char)i);
            }
        }
    }
}