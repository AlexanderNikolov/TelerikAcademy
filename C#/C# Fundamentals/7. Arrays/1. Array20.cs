namespace TAonline.CSharp.Arrays.Homework
{
    using System;

    /// <summary>
    /// Write a program that allocates array of 20 integers and initializes 
    /// each element by its index multiplied by 5. 
    /// Print the obtained array on the console.
    /// </summary>
    class Task1
    {
        static void Main()
        {
            const int Size = 20;
            const int Multiplier = 5;
            int[] output = new int[Size];

            Console.Write("output array = { ");
            for (int index = 0; index < Size; index++)
            {
                Console.Write("{0} ", output[index] = index * Multiplier);
            }
            Console.WriteLine("}");
        }
    }
}