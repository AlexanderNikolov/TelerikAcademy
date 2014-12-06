/*
 * Write a program that reads a rectangular matrix of size N x M 
 * and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

namespace TA2013_MultidimensionalArrays_homework
{
    using System;
    using System.Linq;

    class Square_with_max_sum_in_matrix
    {
        static void Main(string[] args)
        {
            Console.Write("Please input matrix size N (n, n) ");
            string input = Console.ReadLine();
            int sizeN = Convert.ToInt32(input);
            Random rnd = new Random();

            int[,] matrix = new int[sizeN, sizeN];

            for (int row = 0; row < sizeN; row++)
            {
                for (int col = 0; col < sizeN; col++)
                {
                    matrix[row, col] = rnd.Next(1, 10);
                }
            }

            int maxSum = 0;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < sizeN - 2; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < sizeN - 2; col++)
                {
                    currentSum = matrix[row, col] +
                                 matrix[row, col + 1] +
                                 matrix[row, col + 2] +
                                 matrix[row + 1, col] +
                                 matrix[row + 1, col + 1] +
                                 matrix[row + 1, col + 2] +
                                 matrix[row + 2, col] +
                                 matrix[row + 2, col + 1] +
                                 matrix[row + 2, col + 2];

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine("\nOriginal matrix\n");
            PrintArray(matrix);

            int[,] resultMatrix = new int[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    resultMatrix[row, col] = matrix[rowIndex + row, colIndex + col];
                }
            }

            Console.WriteLine("\n3x3 Square with maximum sum\n");
            PrintArray(resultMatrix);
        }

        /// <summary>
        /// Print method with correct visualisation of multidimensional aarays
        /// </summary>
        static void PrintArray<T>(T[,] array)
        {
            //calc whitespaces between columns
            int space = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(space, ' '));
                }

                Console.WriteLine();
            }
        }
    }
}