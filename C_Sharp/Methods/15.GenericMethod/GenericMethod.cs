using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GenericMethod
{
    class GenericMethod
    {
        static void Main(string[] args)
        {
            double product = CalculateProduct(2.3d ,3.1d , 2, 3.6d, 1);
            double sum = CalculateSum(2.1, 3, 1, 5, 4);
            double average = CalculateAverage(2, 0.3, 8.2, 7);
            double maximum = CalculateMaximum(0.2, 3.1, 2, 1.5);
            double minimum = CalculateMinimum(0.1, 2.3, 3.22, 8);
            Console.WriteLine("The product is: {0}", product);
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is: {0}", average);
            Console.WriteLine("The maximum is: {0}", maximum);
            Console.WriteLine("The minimum is: {0}", minimum);
        }

        static T CalculateProduct<T>(params T[] arr)
        {
            dynamic result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }

        static T CalculateSum<T>(params T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static T CalculateAverage<T>(params T[] arr)
        {
            dynamic average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }
            return average / arr.Length;
        }

        static T CalculateMaximum<T>(params T[] arr)
        {
            dynamic maximum = 0;
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

        static T CalculateMinimum<T>(params T[] arr)
        {
            dynamic minimum = 0;
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
