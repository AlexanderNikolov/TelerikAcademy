/*
 * * Write a program that finds the largest area of equal neighbor elements
 * in a rectangular matrix and prints its size. Example:
 *   { 1, 3, 2, 2, 2, 4 } 
     { 3, 3, 3, 2, 4, 4 } 
     { 4, 3, 1, 2, 3, 3 } 
     { 4, 3, 1, 3, 3, 1 } 
     { 4, 3, 3, 3, 1, 1 } => 13 (3) 
 */

namespace TA2013_MultidimensionalArrays_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class DFS
    {
        static int currentCount = 0;
        static int[,] vectors = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };

        static void Main()
        {
            int[,] matrix = { { 1, 8, 2, 2, 2, 8 } , 
                              { 8, 8, 8, 2, 4, 4 } , 
                              { 4, 8, 1, 2, 8, 8 } , 
                              { 4, 8, 1, 8, 8, 1 } , 
                              { 4, 8, 8, 8, 1, 1 } };

            int maxCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0) // If not visited
                    {
                        currentCount = 0;
                        DFS(matrix, i, j);

                        maxCount = Math.Max(currentCount, maxCount);
                    }
                }
            }

            Console.WriteLine(maxCount);
        }

        /// <summary>
        /// Depth-First Search (recursion)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        static void DFS(int[,] matrix, int row, int col)
        {
            int value = matrix[row, col];
            matrix[row, col] = 0; //mark visited

            currentCount++;

            //check neighbours
            for (int node = 0; node < vectors.GetLength(0); node++)
            {
                int rowPlus = row + vectors[node, 0];
                int colPlus = col + vectors[node, 1];

                if (InsideMatrix(matrix, rowPlus, colPlus) && matrix[rowPlus, colPlus] == value)
                {
                    DFS(matrix, rowPlus, colPlus);
                }
            }
        }

        static bool InsideMatrix(int[,] matrix, int x, int y)
        {
            return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
        }
    }
}
