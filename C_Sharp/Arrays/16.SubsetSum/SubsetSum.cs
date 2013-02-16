using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.Write("Sum = ");
            int sum = int.Parse(Console.ReadLine());
            int currentSum;
            string currentIndex;
            for (int i = 0; i < array.Length; i++)
            {
                currentSum = array[i];
                currentIndex = array[i] + " ";
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentSum == sum)
                    {
                        Console.WriteLine(currentIndex);
                        break;
                    }
                    currentIndex += array[j] + " ";
                    if (currentSum < sum)
                    {
                        currentSum += array[j];
                    }
                    if (currentSum > sum)
                    {
                        break;
                    }
                }
            }
        }
    }
}
