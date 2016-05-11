/*
 * We are given a matrix of strings of size N x M. Sequences in 
 * the matrix we define as sets of several neighbor elements located
 * on the same line, column or diagonal. Write a program that finds 
 * the longest sequence of equal strings in the matrix 
 */

namespace TA2013_MultidimensionalArrays_homework
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //input from bgcoder
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = sizes[0];
            var cols = sizes[1];

            var matrix = new string[rows, cols];

            for (int i = 0; i < rows; ++i)
            {
                var rowInput = Console.ReadLine().Split(' ').ToArray();

                for (int j = 0; j < cols; ++j)
                {
                    matrix[i, j] = rowInput[j];
                }
            }//end of input


            int bestLength = int.MinValue;
            int currentLength = 1;
            var row = new List<string>();
            var col = new List<string>();
            var diag = new List<string>();

            //check in rows
            for (int i = 0; i < rows; ++i)
            {
                
                for (int j = 0; j < cols; ++j)
                    row.Add(matrix[i, j]);

                currentLength = checkDuplicates(row);
                if (currentLength > bestLength)
                    bestLength = currentLength;

                row.Clear();

            }

            //check in columns
            for (int j = 0; j < cols; ++j)
            {
                for (int i = 0; i < rows; i++)
                    col.Add(matrix[i, j]);

                currentLength = checkDuplicates(col);
                if (currentLength > bestLength)
                    bestLength = currentLength;

                col.Clear();
            }

            //check diagonaly
            for (int slice = 0; slice < rows + cols - 1; ++slice)
            {
                int z1 = slice < cols ? 0 : slice - cols + 1;
                int z2 = slice < rows ? 0 : slice - rows + 1;

                for (int j = slice - z2; j >= z1; --j)
                    diag.Add(matrix[j,slice - j]);

                currentLength = checkDuplicates(diag);
                if (currentLength > bestLength)
                    bestLength = currentLength;

                diag.Clear();
            }

            for (int slice = 0; slice < rows + cols - 1; ++slice)
            {
                int z1 = slice < cols ? 0 : slice - cols + 1;
                int z2 = slice < rows ? 0 : slice - rows + 1;

                for (int j = slice - z2; j >= z1; --j)
                    diag.Add(matrix[rows - j - 1, slice - j]);

                currentLength = checkDuplicates(diag);
                if (currentLength > bestLength)
                    bestLength = currentLength;

                diag.Clear();
            }

            Console.WriteLine(bestLength);
        }
        
        //helper function with Linq
        public static int checkDuplicates(List<string> collection)
        {
            var duplicates = collection
                    .GroupBy(x => x)
                    .Where(g => g.Count() > 1)
                    .Select(y => new { Element = y.Key, Counter = y.Count() })
                    .ToList();

            int result = int.MinValue;
            foreach (var item in duplicates)
                if (item.Counter > result)
                    result = item.Counter;

            return result;
        }
    }
}
