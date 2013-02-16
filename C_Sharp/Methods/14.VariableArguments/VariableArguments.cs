using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.VariableArguments
{
    class VariableArguments
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateMinimum(2 ,3 ,-5 ,33 , 0, -66, -4));
            Console.WriteLine(CalculateMaximum(4, 9, -4, 22, 3, 8, 99, 3, 0, 4, 100));
            Console.WriteLine(CalculateAverage(3, 2, -9, 12, 77, 3, 12, -23, 5));
            Console.WriteLine(CalculateSum(2, 0, -8, 3, 9, 2, 3, 43, -10));
            Console.WriteLine(CalculateProduct(5, 8, -3, 23, 9, 98, 12, 20, 2));
        }

        static int CalculateProduct(params int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static int CalculateSum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static decimal CalculateAverage(params int[] arr)
        {
            decimal average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }
            return average / arr.Length;
        }

        static int CalculateMaximum(params int[] arr)
        {
            int maximum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    maximum = arr[i];
                }
                else
                {
                    if (arr[i] > maximum)
                    {
                        maximum = arr[i];
                    }
                }
            }
            return maximum;
        }

        static int CalculateMinimum(params int[] arr)
        {
            int minimum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    minimum = arr[i];
                }
                else
                {
                    if (arr[i] < minimum)
                    {
                        minimum = arr[i];
                    }
                }
            }
            return minimum;
        }
    }
}
