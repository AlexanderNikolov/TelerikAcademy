/*
 * Write a program that fills and prints a matrix of size (n, n) 
 * as shown below: (examples for n = 4)
 */

namespace TA2013_MultidimensionalArrays_homework
{
    using System;

    class FillMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Please input matrix size N (n, n) ");
            string input = Console.ReadLine();
            int sizeN = Convert.ToInt32(input);

            int[,] matrix = new int[sizeN, sizeN];

            //variant A
            Console.WriteLine();
            int value = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = value++;
                }
            }
            
            PrintArray(matrix);


            //variant B
            Console.WriteLine();
            value = 1;
            bool direction = true;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (direction)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                        matrix[row, col] = value++;
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        matrix[row, col] = value++;
                }

                direction = !direction;
            }
            
            PrintArray(matrix);


            //variant C
            value = 1;
            Console.WriteLine();

            for (int row = sizeN - 1; row >= 0; row--)
            {
                for (int col = 0; col < sizeN - row; col++)
                {
                    matrix[row + col, col] = value++;
                }
            }
            for (int col = 1; col < sizeN; col++)
            {
                for (int row = 0; row < sizeN - col; row++)
                {
                    matrix[row, col + row] = value++;
                }
            }
            
            PrintArray(matrix);


            //varian D
            Console.WriteLine();
            value = 1;
            int changeDirection = -sizeN;
            int count = sizeN;
            int index = -1;

            do 
            {
                changeDirection = -1 * changeDirection / sizeN;

                for (int i = 0; i < count; i++)
                {
                    index += changeDirection;
                    matrix[index % sizeN, index / sizeN] = value++;
                }

                changeDirection *= sizeN;
                count--;

                for (int j = 0; j < count; j++)
                {
                    index += changeDirection;
                    matrix[index % sizeN, index / sizeN] = value++;
                }

            } while (count > 0);

            PrintArray(matrix);
        }

        /// <summary>
        /// Print method with correct visualization
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