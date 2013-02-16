using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task03
{
    class ComparesArraysLexicographically
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first array size: ");
            int firstSize = int.Parse(Console.ReadLine());
            Console.Write("Enter the second array size: ");
            int secondSize = int.Parse(Console.ReadLine());
            char[] firstArr = new char[firstSize];
            char[] secondArr = new char[secondSize];
            bool areEqual = true;
            if (firstSize != 0 && secondSize != 0)
            {
                Console.WriteLine("Enter the first array elements:");
                for (int i = 0; i < firstSize; i++)
                {
                    firstArr[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the second array elements:");
                for (int i = 0; i < secondSize; i++)
                {
                    secondArr[i] = char.Parse(Console.ReadLine());
                }
                for (int i = 0; i < Math.Max(firstSize, secondSize); i++)
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        Console.WriteLine("The first array is earlier!");
                        areEqual = false;
                        break;
                    }
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine("The second array is earlier!");
                        areEqual = false;
                        break;
                    }
                    if (i == Math.Min(firstSize - 1, secondSize - 1))
                    {
                        if (firstSize < secondSize)
                        {
                            Console.WriteLine("The first array is earlier!");
                            break;
                        }
                        else if (firstSize > secondSize)
                        {
                            Console.WriteLine("The second array is earlier!");
                            break;
                        }
                    }
                }
                if (areEqual == true && firstSize == secondSize)
                {
                    Console.WriteLine("The arrays are equal!");
                }            
            }
            else
            {
                Console.WriteLine("You have entered incorrect data!");
            }
        }
    }
}