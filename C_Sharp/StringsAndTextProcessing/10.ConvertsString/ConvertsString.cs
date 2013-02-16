using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ConvertsString
{
    class ConvertsString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string words = Console.ReadLine();
            Convert(words);
        }

        private static void Convert(string words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(@"\u{0:x4}", (ushort)words[i]);
            }
            Console.WriteLine();
        }
    }
}
