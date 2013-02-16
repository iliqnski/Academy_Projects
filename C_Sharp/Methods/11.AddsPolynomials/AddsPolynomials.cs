using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddsPolynomials
{
    class AddsPolynomials
    {
        static int pow;
        static void Main(string[] args)
        {
            Console.Write("Enter the first polynomial n = ");
            int firstPow = int.Parse(Console.ReadLine());
            int[] firstArr = new int[firstPow + 1];
            for (int i = 0; i <= firstPow; i++)
            {
                Console.Write("a{0} = ", i);
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the second polynomial n = ");
            int secondPow = int.Parse(Console.ReadLine());
            int[] secondArr = new int[secondPow + 1];
            for (int i = 0; i <= secondPow; i++)
            {
                Console.Write("a{0} = ", i);
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            pow = Math.Max(firstPow, secondPow);
            AddingPolynomials(firstArr, secondArr);
        }

        static void AddingPolynomials(int[] firstArr, int[] secondArr)
        {
            int resultLen = Math.Max(firstArr.Length, secondArr.Length);
            int[] result = new int[resultLen];
            int index = 0;
            if (firstArr.Length > secondArr.Length)
            {
                for (int i = 0; i < resultLen; i++)
                {
                    if (i < firstArr.Length - secondArr.Length)
                    {
                        result[i] = firstArr[i];
                    }
                    if (i >= firstArr.Length - secondArr.Length)
                    {
                        result[i] = firstArr[i] + secondArr[index];
                        index++;
                    }
                }
            }
            if (secondArr.Length > firstArr.Length)
            {
                index = 0;
                for (int i = 0; i < resultLen; i++)
                {
                    if (i < secondArr.Length - firstArr.Length)
                    {
                        result[i] = secondArr[i];
                    }
                    if (i >= secondArr.Length - firstArr.Length)
                    {
                        result[i] = firstArr[index] + secondArr[i];
                        index++;
                    }
                }
            }
            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < resultLen; i++)
                {
                    result[i] = firstArr[i] + secondArr[i];
                }
            }
            PrintResult(result);
        }

        static void PrintResult(int[] result)
        {
            for (int i = 0; i < result.Length; i++, pow--)
            {
                Console.Write("{0}X^{1}", result[i], pow);
                if (i < result.Length - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
        }
    }
}
