/* 
 * 8. Define a class Matrix<T> to hold a matrix of numbers 
 *    (e.g. integers, floats, decimals); 
 * 9. Implement an indexer this[row, col] to access the inner matrix cells;
 *10. Implement the operators + and - (addition and subtraction of matrices
 *    of the same size) and * for matrix multiplication. Throw an exception
 *    when the operation cannot be performed. Implement the true operator 
 *    (check for non-zero elements).
*/
using System;
using MatrixSpace;

class ProgramUI
{
    static void Main()
    {
        //new instance test
        Matrix<int> matrix1 = new Matrix<int>(3,3);
        Matrix<int> matrix2 = new Matrix<int>(3,3);

        //init
        for (int i = 0; i < matrix1.Rows; i++)
            for (int j = 0; j < matrix1.Columns; j++)
            {
                matrix1[i, j] = i + 2 * j; //init matrix1
                matrix2[i, j] = i + 3 * j; //init matrix2
            }

        //indexer test
        //Console.WriteLine(" {0}\n",matrix1[1,1]);

        //output
        Console.WriteLine(matrix1.ToString());
        Console.WriteLine(matrix2.ToString());
        Console.WriteLine("Matrix Addition\n{0}", matrix1 + matrix2);
        Console.WriteLine("Matrix Extraction\n{0}", matrix2 - matrix1);
        Console.WriteLine("Matrix Multiplication\n{0}", matrix1 * matrix2);
    }
}
