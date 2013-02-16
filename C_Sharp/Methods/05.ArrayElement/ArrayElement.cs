using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayElement
{
    class ArrayElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] myArr = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write("arr[{0}] = ", i);
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter an array index: ");
            int index = int.Parse(Console.ReadLine());
            CompareNumbers(myArr, index);

        }
        static void CompareNumbers(int[] myArr, int index)
        {
            if (index == 0)
            {
                if (myArr[index] > myArr[index + 1])
                {
                    Console.WriteLine("The element is bigger than the next element");
                }
                else
                {
                    Console.WriteLine("The element is smaller than the next element");
                }
            }
            else if (index == myArr.Length - 1)
            {
                if (myArr[index] > myArr[index - 1])
                {
                    Console.WriteLine("The element is bigger than the previous element");
                }
                else 
                {
                    Console.WriteLine("The element is smaller than the previous element");
                }
            }
            else 
            {
                if (myArr[index] < myArr[index + 1] && myArr[index] < myArr[index - 1])
                {
                    Console.WriteLine("The element is smaller than its two neighbours");
                }
                if (myArr[index] > myArr[index + 1] && myArr[index] > myArr[index - 1])
                {
                    Console.WriteLine("The element is bigger than its two neighbours");
                }
                else
                {
                    Console.WriteLine("The element is not bigger than its two neighbours!");
                }
            }
        }
    }
}
