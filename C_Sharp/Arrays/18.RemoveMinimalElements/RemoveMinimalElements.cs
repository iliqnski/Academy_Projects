using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveMinimalElements
{
    class RemoveMinimalElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            //int[] arr = new int[] { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int len = 0;
            int bestLen = 0;
            int index = 0;
            int lastIndex = 0;
            string currIndex = " ";
            string bestIndex = " ";
            for (int i = 0; i < arr.Length - 1; i ++)
            {
                index = arr[i];
                currIndex = arr[i] + " ";
                len = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (index <= arr[j])
                    {
                        lastIndex = index;
                        index = arr[j];
                        currIndex += arr[j] + " ";
                        len++;
                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestIndex = currIndex;
                        }
                    }
                    if (index > arr[j] && arr[j] > lastIndex)
                    {
                        index = arr[j];
                        currIndex = currIndex.Remove(currIndex.Length - 2);
                        currIndex += arr[j] + " ";
                    }
                }
            }
            Console.WriteLine("The best length with minimal removing of elements is: {0}", bestIndex);
        }
    }
}
