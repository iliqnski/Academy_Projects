using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReturnsMaximalElement
{
    class ReturnsMaximalElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array element: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter a start index: ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("The maximal element is: {0}", GetMaximalElement(arr, startIndex));
            SortArray(arr, startIndex);
            PrintSortedArray(arr, startIndex);
        }
        static void PrintSortedArray(int[] arr, int startIndex)
        {
            Console.WriteLine("The sorted array is:");
            for (int i = startIndex; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }

        static void SortArray(int[] arr, int startIndex)
        {
            int smallest = 0;
            int temp = 0;
            for (int i = startIndex; i < arr.Length; i++)
            {
                smallest = arr[i];
                temp = i + 1;
                while (temp < arr.Length)
                {
                    if (arr[temp] < smallest)
                    {
                        smallest = arr[temp];
                        arr[temp] = arr[i];
                        arr[i] = smallest;
                    }
                    temp++;
                }
            }
        }

        static int GetMaximalElement(int[] arr, int startIndex)
        {
            int max = 0;
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (i == startIndex)
                {
                    max = arr[i];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                }
            }
            return max;
        }
    }
}
