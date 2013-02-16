using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SubsetOfK
{
    class SubsetOfK
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            //int[] arr = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            int currentSum = 0;
            string currentIndex = " ";
            string bestIndex = " ";
            int temp = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                currentIndex = arr[i] + " ";
                currentSum = arr[i];
                int temp1 = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentSum == s && k == temp)
                    {
                        bestIndex = currentIndex;
                        Console.WriteLine(bestIndex);
                        return;
                    }
                    currentIndex += arr[j] + " ";
                    currentSum += arr[j];
                    temp++;
                    if (currentSum == s && k == temp)
                    {
                        bestIndex = currentIndex;
                        Console.WriteLine(bestIndex);
                        return;
                    }
                    if (currentSum > s && temp == k)
                    {
                        currentSum = currentSum - arr[j];
                        currentIndex = currentIndex.Remove(currentIndex.Length - 2);
                        temp--;
                        continue;
                    }
                    if (j == arr.Length - 1 && currentSum != s)
                    {
                        j = temp1 + 1;
                        currentIndex = arr[i] + " ";
                        currentSum = arr[i];
                        temp = 1;
                        temp1++;
                    }
                    if (currentSum < s && temp == k)
                    {
                        currentSum = currentSum - arr[j];
                        currentIndex = currentIndex.Remove(currentIndex.Length - 2);
                        temp--;
                        continue;
                    }
                }
            }
            Console.WriteLine("There are no subsets of K elements that have sum S!");
        }
    }
}
