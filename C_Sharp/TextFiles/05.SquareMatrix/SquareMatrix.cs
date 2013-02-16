using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.SquareMatrix
{
    class SquareMatrix
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                int matrixSize = int.Parse(line);
                int[,] matrix = new int[matrixSize, matrixSize];
                for (int row = 0; row < matrixSize; row++)
                {
                    line = reader.ReadLine();
                    string[] splitLine = line.Split(' ');
                    for (int col = 0; col < matrixSize; col++)
                    {
                        matrix[row, col] = int.Parse(splitLine[col]);
                    }
                }
                int bestSum = 0;
                int bestRow = 0;
                int bestCol = 0;
                for (int row = 0; row < matrixSize - 1; row++)
                {
                    for (int col = 0; col < matrixSize - 1; col++)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }
                using (writer)
                {
                    writer.WriteLine(bestSum);
                }
            }
        }
    }
}
