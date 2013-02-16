using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ConsecutiveLetters
{
    class ConsecutiveLetters
    {
        static void Main(string[] args)
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            int index = 0;
            StringBuilder sb = new StringBuilder();
            CheckLetters(text, index, sb);
            PrintResult(sb);
        }

        private static void PrintResult(StringBuilder sb)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
        }

        private static void CheckLetters(string text, int index, StringBuilder sb)
        {
            while (true)
            {
                int count = 0;
                for (int i = index; i < text.Length; i++)
                {
                    if (text[index] == text[i])
                    {
                        count++;
                        if (i == text.Length - 1)
                        {
                            sb.Append(text[index]);
                            return;
                        }
                    }
                    else
                    {
                        sb.Append(text[index]);
                        index = i;
                        break;
                    }
                }
            }
        }
    }
}
