namespace TAonline.CSharp.Arrays.Homework
{
    using System;

    /// <summary>
    /// Write a program that reads two arrays from the console and compares them element by element.
    /// </summary>
    class Task2
    {
        static void Main(string[] args)
        {
            const int Size = 5;

            int[] firstArr = new int[Size];
            int[] secondArr = new int[Size];
            bool iSArraysEqual = true;

            //only one case - number arrays with equal size
            for (int index = 0; index < Size; index++)
            {
                Console.Write("\nInput number for element {0}/{1} for first array: ", index, Size);
                firstArr[index] = int.Parse(Console.ReadLine());
                Console.Write("Input number for element {0}/{1} for second array: ", index, Size);
                secondArr[index] = int.Parse(Console.ReadLine());

                if (firstArr[index] != secondArr[index])
                {
                    iSArraysEqual = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("firstArray = { " + string.Join(", ", firstArr) + "}");
            Console.WriteLine("secondArray = { " + string.Join(", ", secondArr) + "}");
            if (iSArraysEqual)
            {
                Console.WriteLine("\nArrays are equal!");
            }
            else
            {
                Console.WriteLine("\nWe have different arrays here!");
            }
        }
    }
}