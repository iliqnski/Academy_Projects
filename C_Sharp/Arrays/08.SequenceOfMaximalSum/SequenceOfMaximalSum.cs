using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SequenceOfMaximalSum
{
    class SequenceOfMaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //int[] numbers = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int currentSum = 0;
            int maxSum = 0;
            string currentIndex = " ";
            string bestIndex = " ";
            for (int i = 0; i < numbers.Length; i++)
            {
                currentIndex = numbers[i] + " ";
                currentSum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    currentIndex += numbers[j] + " ";
                    currentSum += numbers[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestIndex = currentIndex;
                    }
                }
            }
            Console.WriteLine("The maximal sum is: {0}", maxSum);
            Console.WriteLine("The elements with maximal sum are: {0}", bestIndex);
        }
    }
}
