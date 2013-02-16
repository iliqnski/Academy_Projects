using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubtractionAndMultiplicationOfPolynomials
{
    class SubtractionAndMultiplicationOfPolynomials
    {
        static int pow;
        static int firstPow;
        static int secondPow;
        static void Main(string[] args)
        {
            Console.Write("Enter the first polynomial n = ");
            firstPow = int.Parse(Console.ReadLine());
            int[] firstArr = new int[firstPow + 1];
            for (int i = 0; i <= firstPow; i++)
            {
                Console.Write("a{0} = ", i);
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the second polynomial n = ");
            secondPow = int.Parse(Console.ReadLine());
            int[] secondArr = new int[secondPow + 1];
            for (int i = 0; i <= secondPow; i++)
            {
                Console.Write("a{0} = ", i);
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            pow = Math.Max(firstPow, secondPow);
            SubtractingPolynomials(firstArr, secondArr);
            MultiplicatingPolynomials(firstArr, secondArr);
        }
        static void MultiplicatingPolynomials(int[] firstArr, int[] secondArr)
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
                        result[i] = firstArr[i] * secondArr[index];
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
                        result[i] = secondArr[i] * firstArr[index];
                        index++;
                    }
                }
            }
            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < resultLen; i++)
                {
                    result[i] = firstArr[i] * secondArr[i];
                }
            }
            PrintResult(result);
        }
        static void SubtractingPolynomials(int[] firstArr, int[] secondArr)
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
                        result[i] = Math.Max(firstArr[i], secondArr[index]) - Math.Min(firstArr[i],secondArr[index]);
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
                        result[i] = Math.Max(firstArr[index], secondArr[i]) - Math.Min(firstArr[index], secondArr[i]);
                        index++;
                    }
                }
            }
            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < resultLen; i++)
                {
                    result[i] = Math.Max(firstArr[i], secondArr[i]) - Math.Min(firstArr[i], secondArr[i]);
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
            pow = Math.Max(firstPow, secondPow);
        }
    }
}
