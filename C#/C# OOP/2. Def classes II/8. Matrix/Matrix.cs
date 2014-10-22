using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixSpace
{
    public class Matrix<T>
    {
        private readonly T[,] matrix = null;

        //.tor
        public Matrix(int rows, int columns)
        {
            this.matrix = new T[rows, columns];
            this.Rows = rows;
            this.Columns = columns;
        }

        //prop
        public int Rows { get; set; }

        public int Columns { get; set; }

        //indexer
        public T this[int row, int col]
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

        //override method
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                    output.AppendFormat(" {0} ", this.matrix[row, col]);
                output.AppendLine();
            }

            return output.ToString();
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + (dynamic)second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, first.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - (dynamic)second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < result.Rows; row++)
                for (int col = 0; col < result.Columns; col++)
                    for (int k = 0; k < first.Columns; k++)
                        result[row, col] = (dynamic)first[row, k] * (dynamic)second[k, col];

            return result;
        }
    }
}