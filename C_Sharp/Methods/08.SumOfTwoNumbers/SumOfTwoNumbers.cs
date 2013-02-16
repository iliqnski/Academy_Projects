using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static string firstStr;
        static string secondStr;
        static string[] firstArr;
        static string[] secondArr;
        static List<int> sum;
        static List<int> result;
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            firstStr = Console.ReadLine();
            Console.Write("Enter the second number: ");
            secondStr = Console.ReadLine();
            firstArr = new string[firstStr.Length];
            secondArr = new string[secondStr.Length];
            sum = new List<int>();
            Reverse();
            SumNumbers();
        }

        static void Reverse()
        {
            int temp = firstArr.Length - 1;
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = firstStr[temp].ToString();
                temp--;
            }
            temp = secondArr.Length - 1;
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = secondStr[temp].ToString();
                temp--;
            }
        }
        static void SumNumbers()
        {
            int residue = 0;
            for (int i = 0; i < Math.Max(firstArr.Length, secondArr.Length); i++)
            {
                if (i < Math.Min(firstArr.Length, secondArr.Length))
                {
                    if (Convert.ToInt32(firstArr[i]) + Convert.ToInt32(secondArr[i]) + residue > 9)
                    {
                        sum.Add((Convert.ToInt32(firstArr[i]) + Convert.ToInt32(secondArr[i]) + residue) % 10);
                        residue = (Convert.ToInt32(firstArr[i]) + Convert.ToInt32(secondArr[i]) + residue) / 10;
                    }
                    else
                    {
                        sum.Add(Convert.ToInt32(firstArr[i]) + Convert.ToInt32(secondArr[i]) + residue);
                        residue = 0;
                    }
                }
                else
                {
                    if (firstArr.Length > secondArr.Length)
                    {
                        sum.Add(Convert.ToInt32(firstArr[i]) + residue);
                    }
                    else
                    {
                        sum.Add(Convert.ToInt32(secondArr[i]) + residue);
                    }
                    residue = 0;
                }
            }
            result = new List<int>();
            for (int i = sum.Count - 1; i >= 0; i--)
            {
                result.Add(sum[i]);
            }
            PrintSum();
        }

        static void PrintSum()
        {
            foreach (var number in result)
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }
    }
}
