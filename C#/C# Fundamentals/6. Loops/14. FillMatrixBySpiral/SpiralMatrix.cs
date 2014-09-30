namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// * Write a program that reads a positive integer number N (N < 20) from console
    /// and outputs in the console the numbers 1 ... N. Numbers arranged as a spiral!
    /// </summary>
    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("Input matrix dimension N (0<N<20): "); 
            int numberN = int.Parse(Console.ReadLine());

            int[,] matrix = new int[numberN, numberN];

            int value = 0;
            int count = numberN;
            int fluct = -numberN;
            int index = -1;

            do
            {
                fluct = -1 * fluct / numberN;

                for (int i = 0; i < count; i++)
                {
                    index += fluct;
                    matrix[index / numberN, index % numberN] = value++;
                }

                fluct *= numberN;
                count--;

                for (int i = 0; i < count; i++)
                {
                    index += fluct;
                    matrix[index / numberN, index % numberN] = value++;
                }
            } while (count > 0);

            //output
            Print2DArray(matrix);
        }

        static void Print2DArray(int[,] array)
        {
            int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

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