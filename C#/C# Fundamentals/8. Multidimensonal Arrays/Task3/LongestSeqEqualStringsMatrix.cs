/*
 * We are given a matrix of strings of size N x M. Sequences in 
 * the matrix we define as sets of several neighbor elements located
 * on the same line, column or diagonal. Write a program that finds 
 * the longest sequence of equal strings in the matrix 
 */

namespace TAOnline_8_MultidimensionalArrays
{
    using System;
    using System.Linq;

    class LongestSeqEqualStringsMatrix
    {
        static void Main(string[] args)
        {
            
            string[,] matrix =  
            {
                {"ha", "fifi", "ho",   "hi"}, 
                {"fo", "ha",   "hihi", "xx"},
                {"vi", "ho",   "ha",   "xx"},
            };

            int bestIndexCol = 0;
            int bestIndexRow = 0;
            int bestLength = 0;

            //searching in columns
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int length = 1;
                int indexCol = 0;

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, indexCol] == matrix[i, j])
                    {
                        length++;
                    }
                    else
                    {
                        if (length > 2)
                        {
                            if (bestLength < length)
                            {
                                bestIndexCol = indexCol;
                                bestIndexRow = i;
                                bestLength = length;
                            }
                        }

                        indexCol = j;
                        length = 1;
                    }

                    //in case if subset scrab end of loop
                    if (length > 2)
                    {
                        if (bestLength < length)
                        {
                            bestIndexCol = indexCol;
                            bestIndexRow = i;
                            bestLength = length;
                        }
                    }
                }
            }

            //searching in rows
            for (int ii = 0; ii < matrix.GetLength(1); ii++)
            {
                int length = 1;
                int indexRow = 0;
                for (int jj = 1; jj < matrix.GetLength(0); jj++)
                {
                    if (matrix[indexRow, ii] == matrix[jj, ii]) 
                    {
                        length++;
                    }
                    else
                    {
                        if (length > 2)
                        {
                            if (bestLength < length)
                            {
                                bestIndexCol = ii;
                                bestIndexRow = indexRow;
                                bestLength = length;
                            }
                        }

                        indexRow = jj;
                        length = 1;
                    }
                    //in case if subset scrab end of loop
                    if (length > 2)
                    {
                        if (bestLength < length)
                        {
                            bestIndexCol = ii;
                            bestIndexRow = indexRow;
                            bestLength = length;
                        }
                    }
                }
            }

            //searching diagonals
            int limit = Math.Abs(matrix.GetLength(0) - matrix.GetLength(1)) + 1;

            for (int iter = 0; iter < limit; iter++)
            {
                int length = 1;
                for (int step = 1; step < matrix.GetLength(1) - 1; step++)
                {
                    if (matrix[step - 1, step - 1] == matrix[step, step])
                    {
                        length++;
                    }
                    else
                    {
                        if (length > 2)
                        {
                            if (bestLength < length)
                            {
                                bestIndexCol = iter;
                                bestIndexRow = iter;
                                bestLength = length;
                            }
                        }
                    }
                    //in case if subset scrab end of loop
                    if (length > 2)
                    {
                        if (bestLength < length)
                        {
                            bestIndexCol = iter;
                            bestIndexRow = iter;
                            bestLength = length;
                        }
                    }
                }
            }

            int count = 1;
            string result = "";
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(1); j++)
                {
                    int col = j;
                    int row = i;

                    if (col >= matrix.GetLength(1) - 1 || row >= matrix.GetLength(0) - 1)
                    {
                        break;
                    }
                    else
                    {
                        while (col > 0 && row < matrix.GetLength(0) - 1)
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 1])
                            {
                                count++;
                                if (count >= bestLength)
                                {
                                    result = matrix[row, col];
                                    bestLength = count;
                                }
                                
                                row++;
                                col--;
                            }
                            else
                            {
                                count = 1;
                                break;
                            }
                        }

                        count = 1;
                    }
                }
            }

            //output
            for (int index = 0; index < bestLength; index++)
            {
                Console.Write(matrix[bestIndexRow, bestIndexCol] + " ");
            }
            
            Console.WriteLine();
            PrintMatrix(matrix);
        }

        /// <summary>
        /// Print method with correct visualisation
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintMatrix(string[,] matrix)
        {
            int cellSize = matrix[0, 0].Length;
            foreach (string cell in matrix) cellSize = Math.Max(cellSize, cell.Length);

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].PadRight(cellSize, ' ') +
                                 (j != matrix.GetLength(1) - 1 ? " " : "\n"));
        }
    }
}
