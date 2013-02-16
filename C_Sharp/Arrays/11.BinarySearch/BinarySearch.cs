using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter an element from the array: ");
            int element = int.Parse(Console.ReadLine());
            int middle = 0;
            int firstIndex = 0;
            int lastIndex = size;
            Array.Sort(arr);
            while (true)
            {
                middle = (firstIndex + lastIndex) / 2;
                if (firstIndex == lastIndex - 1)
                {
                    Console.WriteLine(-1);
                    break;
                }
                if (arr[middle] == element)
                {
                    Console.WriteLine("The index of the element is: {0}", middle);
                    break;
                }
                if (arr[middle] > element)
                {
                    lastIndex = middle;
                }
                else
                {
                    firstIndex = middle;
                }
            }
        }
    }
}
