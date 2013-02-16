using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindMaximalSum
{
    class FindMaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for K (N > K > 0): ");
            int k = int.Parse(Console.ReadLine());
            if (k < 0 || k > n)
            {
                Console.WriteLine("You have entered incorrect data!");
                return;
            }
            int[] myArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                myArr[i] = int.Parse(Console.ReadLine());
            }
            string count = " ";
            string bestCount = " ";
            int sum = 0;
            int bestSum = 0;
            int temp = 0;
            for (int i = 0; i < n - (k - 1); i++)
            {
                sum = myArr[i];
                count = myArr[i] + " ";
                temp = i + 1;
                for (int j = 1; j < k; j++)
                {
                    sum += myArr[temp];
                    count += myArr[temp] + " ";
                    temp++;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestCount = count;
                }
            }
            Console.WriteLine("Those \"{0}\" elements that have maximal sum are: {1}", k, bestCount);
        }
    }
}
