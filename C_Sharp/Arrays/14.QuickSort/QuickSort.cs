using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class QuickSort
    {
        static int[] array;
        static void Main(string[] args)
        {
            array = new int[] { 1, 3, -9, 8, 3, 4, 1, 2 };
            QuickSorted(0, array.Length - 1);
            PrintArray();
        }
        static void PrintArray()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine(array[array.Length - 1]);
        }
        static void QuickSorted(int left, int right)
        {
            int pivot, currentLeft, currentRight;
            currentLeft = left;
            currentRight = right;
            pivot = array[left];
            while (left < right)
            {
                while (array[right] >= pivot && left < right)
                {
                    right--;
                }
                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }
                while (array[left] <= pivot && left < right)
                {
                    left++;
                }
                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            array[left] = pivot;
            pivot = left;
            left = currentLeft;
            right = currentRight;
            if (left < pivot)
            {
                QuickSorted(left, pivot - 1);
            }
            if (right > pivot)
            {
                QuickSorted(pivot + 1, right);
            }
        }
    }
}
