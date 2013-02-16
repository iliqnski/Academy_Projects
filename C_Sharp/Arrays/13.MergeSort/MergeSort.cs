using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSort
    {
        static int[] arr;
        static void Main()
        {
            arr = new int[] { -1, -9, 10, 2, -6, 0 };
            Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
        static void Sort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }
            int[] left = new int[arr.Length / 2];
            int[] right = new int[arr.Length - left.Length];
            int index = 0;

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }
            for (int i = left.Length; i < arr.Length; i++)
            {
                right[index] = arr[i];
                index++;
            }
            Sort (left);
            Sort (right);
            int[] merge = Merge(left, right);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = merge[i];
            }
        }
        private static int[] Merge(int[] left, int[] right)
        {
            int[] sorted = new int[left.Length + right.Length];
            int sortedIndex = 0; 
            int leftIndex = 0;
            int rightIndex = 0; 
            while (leftIndex < left.Length || rightIndex < right.Length)
            {
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        sorted[sortedIndex] = left[leftIndex];
                        sortedIndex++;
                        leftIndex++;
                    }
                    else
                    {
                        sorted[sortedIndex] = right[rightIndex];
                        sortedIndex++;
                        rightIndex++;
                    }
                }
                if (leftIndex >= left.Length && rightIndex < right.Length)
                {
                    sorted[sortedIndex] = right[rightIndex];
                    sortedIndex++;
                    rightIndex++;
                }
                if (leftIndex < left.Length && rightIndex >= right.Length)
                {
                    sorted[sortedIndex] = left[leftIndex];
                    sortedIndex++;
                    leftIndex++;
                }
            }
            return sorted;
        }
    }
}
