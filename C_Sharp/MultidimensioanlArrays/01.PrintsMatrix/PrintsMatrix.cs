using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintsMatrix
{
    class PrintsMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a matrix size: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int value = 1;
            // a) Task;
            //while (value <= n * n)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        for (int row = 0; row < matrix.GetLength(0); row++)
            //        {
            //            matrix[row, col] = value;
            //            value++;
            //        }
            //    }
            //}
            //Console.WriteLine();
            // b) Task;
            //int row = 0;
            //int col = 0;
            //while (value <= n * n)
            //{
            //    matrix[row, col] = value;
            //    if (value == n * n)
            //    {
            //        break;
            //    }
            //    value++;
            //    row++;
            //    if (row == matrix.GetLength(1))
            //    {
            //        col++;
            //        while (row > 0)
            //        {
            //            row--;
            //            matrix[row, col] = value;
            //            value++;
            //        }
            //        col++;
            //    }
            //    if (col == matrix.GetLength(0))
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //c) Task;
            //int row = n - 1;
            //int col = 0;
            //matrix[row, col] = 1;
            //int lastIndex = 0;
            //int temp = 1;
            //while (value <= n * n)
            //{
            //    if (n == 1)
            //    {
            //        matrix[row, col] = 1;
            //        break;
            //    }
            //    if (row != 0)
            //    {
            //        row--;
            //    }
            //    lastIndex = row;
            //    value++;
            //    matrix[row, col] = value;
            //    while (row != n - 1 && col != n - 1)
            //    {
            //        row++;
            //        col++;
            //        value++;
            //        matrix[row, col] = value;
            //    }
            //    if (col < n - 1)
            //    {
            //        col = 0;
            //    }
            //    else
            //    {
            //        col = temp;
            //        temp++;
            //    }
            //    row = lastIndex;
            //    if (value == n * n - 1)
            //    {
            //        row = 0;
            //        col = n - 1;
            //        value++;
            //        matrix[row, col] = value;
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //d) Task;
            int row = 0;
            int col = 0;
            matrix[row, col] = value;
            int temp = 1;
            int len = 0;
            while (value <= n * n)
            {
                while (row < matrix.GetLength(1) - temp)
                {
                    col = len;
                    row++;
                    value++;
                    matrix[row, col] = value;
                }
                while (col < matrix.GetLength(0) - temp)
                {
                    col++;
                    value++;
                    matrix[row, col] = value;
                }
                while (row > len)
                {
                    row--;
                    value++;
                    matrix[row, col] = value;
                }
                while (col > len + 1)
                {
                    col--;
                    value++;
                    matrix[row, col] = value;
                }
                len++;
                temp++;
                if (value == n * n)
                {
                    break;
                }
            }
            Console.WriteLine();
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(" " + matrix[rows, cols]);
                    Console.Write("\t");
                }
                Console.WriteLine("\t");
                Console.WriteLine();
            }
        }
    }
}
