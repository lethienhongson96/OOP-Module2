using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    class Exercise_Calculate_inTwoMaxtrix
    {
        public int[,] creRndMatrixArr(int sides)
        {
            int[,] SquareMatrix = new int[sides, sides];
            Random rnd = new Random();
            for (int i = 0; i < SquareMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < SquareMatrix.GetLength(1); j++)
                {
                    SquareMatrix[i, j] = rnd.Next(10, 40);
                }
            }

            return SquareMatrix;
        }

        public int[,] SumOfTwoMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] sumTwoMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];

            for (int i=0;i<matrix1.GetLength(0);i++)
            {
                for (int j=0;j<matrix1.GetLength(1);j++)
                {
                    sumTwoMatrix[i,j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return sumTwoMatrix;
        }

        public void PrintMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public int[,] MultOfTwoMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] multTwoMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    multTwoMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }

            return multTwoMatrix;
        }
    }
}
