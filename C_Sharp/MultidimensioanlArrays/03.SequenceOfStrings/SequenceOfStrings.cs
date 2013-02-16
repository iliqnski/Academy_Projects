using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceOfStrings
{
    class SequenceOfStrings
    {
        static void Main(string[] args)
        {
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("m = ");
            //int m = int.Parse(Console.ReadLine());
            int n = 3;
            int m = 3;
            string[,] matrix = {
                                { "ha","d","a"},
                                { "a","c","a"},
                                { "ha","d","a"},
                                };
            int bestCount = 0;
            string currentLength = " ";
            string bestLength = " ";
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < m; col++)
            //    {
            //        Console.Write("matrix[{0},{1}] = ", row, col);
            //        matrix[row, col] = Console.ReadLine();
            //    }
            //}
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    currentLength = matrix[row, col] + " ";
                    int tempCol = col;
                    int tempRow = row;
                    int count = 1;
                    while (tempCol < m - 1 && matrix[tempRow, tempCol] == matrix[tempRow, tempCol + 1])
                    {
                        count++;
                        currentLength += matrix[tempRow, tempCol + 1] + " ";
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestLength = currentLength;
                        }
                        tempCol++;
                        if (tempCol == m - 1)
                        {
                            break;
                        }
                    }
                    currentLength = matrix[row, col] + " ";
                    count = 1;
                    tempCol = col;
                    tempRow = row;
                    while (tempRow < n - 1 && tempCol < m - 1 && matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol + 1])
                    {
                        count++;
                        currentLength += matrix[tempRow + 1, tempCol + 1] + " ";
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestLength = currentLength;
                        }
                        tempCol++;
                        tempRow++;
                        if (tempCol == m - 1)
                        {
                            break;
                        }
                    }
                    currentLength = matrix[row, col] + " ";
                    count = 1;
                    tempCol = col;
                    tempRow = row;
                    while (tempRow < n - 1 && matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol])
                    {
                        count++;
                        currentLength += matrix[tempRow + 1, tempCol] + " ";
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestLength = currentLength;
                        }
                        tempRow++;
                        if (tempRow == n - 1)
                        {
                            break;
                        }
                    }
                    currentLength = matrix[row, col] + " ";
                    count = 1;
                    tempCol = col;
                    tempRow = row;
                    while (tempRow < n - 1 && tempCol > 0 && matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol - 1])
                    {
                        count++;
                        currentLength += matrix[tempRow + 1, tempCol - 1] + " ";
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestLength = currentLength;
                        }
                        tempRow++;
                        tempCol--;
                        if (tempRow == n - 1)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(bestLength);
        }
    }
}
