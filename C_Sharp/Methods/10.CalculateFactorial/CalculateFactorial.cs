using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.CalculateFactorial
{
    class CalculateFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1..100]: ");
            int number = int.Parse(Console.ReadLine());
            GetFactorial(number);
        }

        static void GetFactorial(int number)
        {
            BigInteger result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }
            Console.WriteLine(result);
        }
    }
}
