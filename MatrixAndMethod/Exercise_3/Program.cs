using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixNxM matrixNxMOb = new MatrixNxM();

            int[,] matrix = matrixNxMOb.creRndMatrixArr(2, 3);
            matrixNxMOb.PrintMatrix(matrix);
            Console.WriteLine("-----------------------------");

            /* Console.WriteLine("enter a number: ");
             int v = Convert.ToInt32(Console.ReadLine());*/
            matrixNxMOb.MatrixMxN(matrix);
        }
    }
}
