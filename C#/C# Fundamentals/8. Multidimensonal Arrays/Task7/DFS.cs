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
    class Program
    {
        static void Main(string[] args)
        {
            //input from bgcoder
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = sizes[0];
            var cols = sizes[1];

            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; ++i)
            {
                var rowInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < cols; ++j)
                {
                    matrix[i, j] = rowInput[j];
                }
            }//end of input

            var visited = new bool[rows, cols];
            int bestLength = 0; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int currentLength = 0;
                    int currentNumber = matrix[i,j];

                    DFS(matrix, ref visited, i, j, currentNumber, ref currentLength);

                    if (currentLength > bestLength)
                        bestLength = currentLength;
                }
            }

            Console.WriteLine(bestLength);

        }

        private static void DFS(int[,] matrix, ref bool[,] visited, int row, int col, int currentNumber, ref int currentLength)
        {
            if (row < 0 || row >= matrix.GetLength(0) ||
                col < 0 || col >= matrix.GetLength(1) || visited[row, col] == true)
                return;

            if (matrix[row,col] == currentNumber)
            {
                currentLength++;
                visited[row, col] = true;

                DFS(matrix, ref visited, row - 1, col, currentNumber, ref currentLength);
                DFS(matrix, ref visited, row + 1, col, currentNumber, ref currentLength);
                DFS(matrix, ref visited, row, col -1, currentNumber, ref currentLength);
                DFS(matrix, ref visited, row, col + 1, currentNumber, ref currentLength);
            }
        }
    }
}
