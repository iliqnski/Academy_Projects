using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static List<string> reversed = new List<string>();
        static decimal num;
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            num = decimal.Parse(Console.ReadLine());
            string numStr = num.ToString();
            ReversesNumber(numStr);
        }
        static void ReversesNumber(string revNum)
        {
            if (num > 0)
            {
                for (int i = revNum.Length - 1; i >= 0; i--)
                {
                    reversed.Add(revNum[i].ToString());
                }
                PrintsReversedNumber();
            }
            else
            {
                reversed.Add("-");
                for (int i = revNum.Length - 1; i > 0; i--)
                {
                    reversed.Add(revNum[i].ToString());
                }
                PrintsReversedNumber();
            }
        }
        static void PrintsReversedNumber()
        {
            foreach (var number in reversed)
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }
    }
}
