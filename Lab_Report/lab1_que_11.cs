using System;

namespace MatrixMultiplication
{
    class Program
    {
        //static void Main(string[] args)
        //{ 
        //   Console.Write("Enter number of rows for first matrix: ");
        //    int rows1 = int.Parse(Console.ReadLine());
        //    Console.Write("Enter number of columns for first matrix: ");
        //    int cols1 = int.Parse(Console.ReadLine());

        //    Console.Write("Enter number of rows for second matrix: ");
        //    int rows2 = int.Parse(Console.ReadLine());
        //    Console.Write("Enter number of columns for second matrix: ");
        //    int cols2 = int.Parse(Console.ReadLine());

        //    if (cols1 != rows2)
        //    {
        //        Console.WriteLine("Matrix multiplication not possible! (cols1 must equal rows2)");
        //        return;
        //    }

        //    int[,] matrix1 = new int[rows1, cols1];
        //    int[,] matrix2 = new int[rows2, cols2];
        //    int[,] result = new int[rows1, cols2];

        //    Console.WriteLine("\nEnter elements of first matrix:");
        //    for (int i = 0; i < rows1; i++)
        //    {
        //        for (int j = 0; j < cols1; j++)
        //        {
        //            Console.Write($"matrix1[{i},{j}]: ");
        //            matrix1[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    Console.WriteLine("\nEnter elements of second matrix:");
        //    for (int i = 0; i < rows2; i++)
        //    {
        //        for (int j = 0; j < cols2; j++)
        //        {
        //            Console.Write($"matrix2[{i},{j}]: ");
        //            matrix2[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    for (int i = 0; i < rows1; i++)
        //    {
        //        for (int j = 0; j < cols2; j++)
        //        {
        //            result[i, j] = 0;
        //            for (int k = 0; k < cols1; k++)
        //            {
        //                result[i, j] += matrix1[i, k] * matrix2[k, j];
        //            }
        //        }
        //    }

        //    Console.WriteLine("\nResultant Matrix:");
        //    for (int i = 0; i < rows1; i++)
        //    {
        //        for (int j = 0; j < cols2; j++)
        //        {
        //            Console.Write(result[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
