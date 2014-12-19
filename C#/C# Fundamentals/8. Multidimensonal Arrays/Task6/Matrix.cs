﻿/*
 * Write a class Matrix, to holds a matrix of integers. Overload 
 * the operators for adding, subtracting and multiplying of matrices, 
 * indexer for accessing the matrix content and ToString().
 */

namespace TA2013_MultidimensionalArrays_homework
{
    using System;

    class Matrix
    {
        private int[,] matrix;

        /// <summary>
        /// Class constructor
        /// </summary>
        public Matrix(int rows, int columns)
        {
            this.matrix = new int[rows, columns];
        }

        #region Properties of class.

        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return this.matrix.GetLength(1); }
        }

        #endregion

        /// <summary>
        /// Indexer
        /// </summary>
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }


        #region Overloads. Up to many

        public override string ToString()
        {
            string result = null;

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                    result += matrix[row, col] + " ";
                result += Environment.NewLine;
            }

            return result;
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Columns);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Columns; col++)
                {
                    for (int k = 0; k < first.Columns; k++)
                    {
                        result[row, col] = first[row, k] * second[k, col];
                    }
                }
            }
            return result;
        }

        #endregion
    }
}