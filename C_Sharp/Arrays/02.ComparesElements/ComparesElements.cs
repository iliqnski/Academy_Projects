using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ComparesElements
{
    class ComparesElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first array size: ");
            int firstSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the second array size: ");
            int secondSize = int.Parse(Console.ReadLine());       
            if (firstSize == 0 && secondSize == 0)
            {
                Console.WriteLine("You have entered incorrect data!");
                return;
            }
            if (firstSize == secondSize)
            {
                int[] firstArr = new int[firstSize];
                int[] secondArr = new int[secondSize];
                bool areEqual = true;
                Console.WriteLine("Enter the first array elements:");
                for (int i = 0; i < firstSize; i++)
                {
                    firstArr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the second array elements:");
                for (int i = 0; i < secondSize; i++)
                {
                    secondArr[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < firstSize; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
                Console.WriteLine("Are the arrays equal? {0}", areEqual);
            }
            else
            {
                Console.WriteLine("The arrays are not equal!");
            }
        }
    }
}
