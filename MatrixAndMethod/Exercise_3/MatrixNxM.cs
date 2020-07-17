using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3
{
    class MatrixNxM
    {
        public int[,] creRndMatrixArr(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(20, 60);
                }
            }
            return matrix;
        }

        public int[,] VArr(int[,] matrix,int v)
        {

            for (int i=0;i<matrix.GetLength(0);i++)
            {
                for (int j=0;j<matrix.GetLength(1);j++)
                {
                    if (matrix[i,j]!=v)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        public int[,] DiviArr(int[,] matrix)
        {
            int diviby = 5;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % diviby != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        public void MatrixMxN(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                string result = "";
                for (int j =0; j <row; j++)
                {
                    result += $"{matrix[j, i]} ";
                }
                Console.WriteLine(result);
            }

        }

        public void PrintMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "  ");
                }

                Console.WriteLine();
            }
        }
    }
}
