using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentElement
{
    class MostFrequentElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //int[] numbers = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int count = 1;
            int bestCount = 0;
            int bestElement = 0;
            int currentElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentElement = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestElement = currentElement;
                        }
                    }
                }
                count = 1;
            }
            if (bestCount != 0)
            {
                Console.WriteLine("The most frequent element is: {0} ({1} times)", bestElement, bestCount);
            }
            else
            {
                Console.WriteLine("There is not any frequent element in the array!");
            }
        }
    }
}
