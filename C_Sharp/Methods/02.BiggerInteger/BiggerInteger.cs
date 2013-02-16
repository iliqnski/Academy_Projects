using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BiggerInteger
{
    class BiggerInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            int temp = GetMax(firstNum, secondNum);
            int max = GetMax(temp, thirdNum);
            Console.WriteLine("The biggest number is: {0}", max);          
        }
        static int GetMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }
    }
}
