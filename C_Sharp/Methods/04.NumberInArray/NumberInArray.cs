using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberInArray
{
    public class NumberInArray
    {
        static void Main()
        {
            Console.Write("Enter an array length: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrSize];
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                numArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number to check: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNumber(numArr, number));
        }
        public static int GetNumber(int[] numArr, int number)
        {
            int count = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (number == numArr[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
