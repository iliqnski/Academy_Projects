using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestArea
{
    class LargestArea
    {
        static string[,] matrix = {
                                { "3", "1", "3" },
                                { "3", "3", "3" },
                                { "2", "3", "3" },
                            };
        static int count = 0;
        static int bestCount = 0;
        static string currentElement = " ";
        static string visited = " ";
        static void Main(string[] args)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    currentElement = matrix[row, col];
                    FindArea(row, col);
                    count = 0;
                }
            }           
            Console.WriteLine("The largest size of equal neighbour elements is {0} elements",bestCount);           
        }
        static void FindArea(int row, int col)
        {
            if ((col < 0) || (row < 0) || (col >= matrix.GetLength(1)) || (row >= matrix.GetLength(0)))
            {
                return;
            }
            if (matrix[row, col] == currentElement && matrix[row,col] != visited)
            {
                count++;
                matrix[row, col] = visited;
                if (count > bestCount)
                {
                    bestCount = count;
                }
            }      
            else
            {
                return;
            }
            FindArea(row, col - 1); //left
            FindArea(row - 1, col); //up
            FindArea(row, col + 1); //right
            FindArea(row + 1, col); //down
            visited = matrix[row, col];
        }
    }
}
