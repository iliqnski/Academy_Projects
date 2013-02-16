using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task01
{
    class PrintsAllPermutations
    {
        static int n;
        static int k;
        static int temp;
        static int[] arr;
        static void Main(string[] args)
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            k = n;
            Permutation(0);
        }
        static void Permutation(int k)
        {
            if (k == n)
            {
                Print();
                return;
            }
            for (int i = k; i < n; i++)
            {
                temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
                Permutation(k + 1);               
            }
        }
        static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}

