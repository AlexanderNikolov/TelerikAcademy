/*
 * Write a program that reads a text file containing a square matrix of numbers
 * and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. Each of the next 
 * N lines contain N numbers separated by space. The output should be a single number 
 * in a separate text file. 
 * Example:
 *      4
 *      2 3 3 4
 *      0 2 3 4	----->	17
 *      3 7 1 2
 *      4 3 3 2
 */

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string pathIn = "input.txt";
            string pathOut = "output.txt";

            MaxMatrixSquare(pathIn, pathOut);

            FileToConsolePrinter(pathOut);
        }

        static void MaxMatrixSquare(string pathIn, string pathOut)
        {
            using (var output = new StreamWriter(pathOut, true))
            {
                using (StreamReader stream = new StreamReader(pathIn))
                {
                    int size = int.Parse(stream.ReadLine());
                    int[,] matrix = new int[size, size];
                    int row = 0;
                    while (!stream.EndOfStream)
                    {
                        string[] line = stream.ReadLine()
                                              .Split(new char[] { ' ' }, 
                                              StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < line.Length; i++)
                        {
                            matrix[row, i] = Convert.ToInt32(line[i]);
                        }
                        row++;
                    }
                    output.WriteLine(MatrixBestSum(size, matrix));
                }
            }
        }

        private static int MatrixBestSum(int size, int[,] matrix)
        {
            int bestSum = 0;
            for (int row = 0; row < size - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < size - 1; col++)
                {
                    sum = matrix[row, col] +
                                 matrix[row, col + 1] +
                                 matrix[row + 1, col] +
                                 matrix[row + 1, col + 1];

                    if (bestSum < sum)
                        bestSum = sum;
                }
            }

            return bestSum;
        }

        //TODO: modified method to fill data in array
        static void FileToConsolePrinter(string path)
        {
            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                    Console.WriteLine(stream.ReadLine());
            }
        }

        //static int MatrixBestSum(int[,] matrix)
        //{
        //    int bestSum = int.MinValue;
        //    int sum = 0;
        //    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        //        {
        //            for (int i = 0; i < 2; i++)
        //                for (int j = 0; j < 2; j++)
        //                    sum += matrix[row + i, col + j];
        //
        //            if (sum > bestSum) 
        //              bestSum = sum;
        //
        //            sum = 0;
        //        }
        //    }
        //    return bestSum;
        //}
    }
}
