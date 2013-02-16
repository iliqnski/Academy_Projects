using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static StringBuilder sb;
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbidden = "PHP, CLR, Microsoft";
            string[] forbWords = forbidden.Split(',', ' ');
            Replacement(text, forbWords);
            Printresult();
        }

        private static void Printresult()
        {
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();
        }

        private static void Replacement(string text, string[] forbWords)
        {
            sb = new StringBuilder(text);
            for (int i = 0; i < forbWords.Length; i++)
            {
                int index = text.IndexOf(forbWords[i]);
                if (index != -1)
                {
                    for (int j = index; j < index + forbWords[i].Length; j++)
                    {
                        sb[j] = '*';
                    }
                }
                else
                {  
                    break;
                }
            }
        }
    }
}
