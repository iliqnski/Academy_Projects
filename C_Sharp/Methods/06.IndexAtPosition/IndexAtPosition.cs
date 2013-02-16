using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IndexAtPosition
{
    class IndexAtPosition
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
            Console.WriteLine(GetMaxIndex(arr)); 
        }
        static int GetMaxIndex(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr[0];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        return arr[i];
                    }
                }
                else
                {
                    if (i == arr.Length - 1)
                    {
                        if (arr[i] > arr[i - 1])
                        {
                            return arr[i];
                        }
                    }
                    else
                    {
                        if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                        {
                            return arr[i];
                        }
                    }
                }
            }
            return -1;
        }
    }
}
