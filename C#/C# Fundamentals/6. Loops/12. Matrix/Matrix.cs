namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that reads from the console a positive integer number N (N < 20)
    /// and outputs a matrix like the following:	N = 3 || N = 4
    /// </summary>
    class Matrix
    {
        static void Main()
        {
            Console.Write("Input matrix dimension N (N>0): "); 
            int numberN = int.Parse(Console.ReadLine());

            int[,] matrix = new int[numberN, numberN];

            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberN; j++)
                {
                    matrix[i, j] = i * numberN + j + 1;
                }
            }

            PrintArray(matrix);
        }

        // 
        /// <summary>
        /// Method to print arrays, pads numbers so they line up in columns 
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(int[,] array)
        {
            int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1; //calc whitespaces

            for (int i = 0; i < array.GetLength(0); i++)  
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(n, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}