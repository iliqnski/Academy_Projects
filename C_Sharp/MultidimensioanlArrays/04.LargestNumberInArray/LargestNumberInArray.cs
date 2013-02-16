using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LargestNumberInArray
{
    class LargestNumberInArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            int index = Array.BinarySearch(arr, k);
            if (index < 0)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (arr[i] <= k)
                    {
                        Console.WriteLine("The biggest number in the array, which is <= k is: {0}", arr[i]);
                        break;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("All numbers in the array are bigger than k!");
                    }
                }
            }
            else
            {
                Console.WriteLine("The biggest number in the array, which is <= k is: {0}", arr[index]);
            }
        }
    }
}
