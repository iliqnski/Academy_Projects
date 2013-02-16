using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());
            if (size == 0)
            {
                Console.WriteLine("You have entered incorrect data!");
                return;
            }
            int[] myArr = new int[size];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < size; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            int bestCount = 0;
            string current = " " + myArr[0];
            string bestRow = myArr[0].ToString();
            for (int i = 0; i < size - 1; i++)
            {
                if (myArr[i] < myArr[i + 1])
                {
                    current += " " + myArr[i + 1];
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = current;
                    }
                }
                else
                {
                    count = 0;
                    current = " " + myArr[i + 1];
                }
            }
            Console.WriteLine("The longest row with growing elements is: {0}", bestRow);
        }
    }
}
