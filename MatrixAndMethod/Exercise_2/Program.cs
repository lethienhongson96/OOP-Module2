using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise_Calculate_inTwoMaxtrix matrixOb = new Exercise_Calculate_inTwoMaxtrix();
            int[,] matrix1 = matrixOb.creRndMatrixArr(2);
            matrixOb.PrintMatrix(matrix1);
            Console.WriteLine("---------------------------------------");
            int[,] matrix2 = matrixOb.creRndMatrixArr(2);
            matrixOb.PrintMatrix(matrix2);
            Console.WriteLine("---------------------------------------");
            int[,] multi = matrixOb.MultOfTwoMatrix(matrix1, matrix2);
            matrixOb.PrintMatrix(multi);
        }
    }
}
