using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
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
            Console.Write("Sum = ");
            int sum = int.Parse(Console.ReadLine());
            //int[] numbers = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            //int sum = 7;
            int currentSum = 0;
            string currentLength = " ";
            string bestLength = " ";
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum = numbers[i];
                currentLength = " " + numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    currentSum += numbers[j];
                    currentLength += " " + numbers[j];
                    if (currentSum > sum)
                    {
                        break;
                    }
                    if (currentSum == sum)
                    {
                        bestLength = currentLength;
                    }
                }
            }
            if (bestLength != " ")
            {
                Console.WriteLine("The sequence of elements with sum = {0} is:{1}", sum, bestLength);
            }
            else
            {
                Console.WriteLine("There are no sequences of elements with sum = {0}", sum);
            }
        }
    }
}
