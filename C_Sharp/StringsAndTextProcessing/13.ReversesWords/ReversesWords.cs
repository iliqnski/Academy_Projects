using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReversesWords
{
    class ReversesWords
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] words = text.Split(new char[] { '!', '.', ',', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            string[] marks = text.Split(new char[]{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
                                                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                   '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                   'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                   'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0','*', '/', '=', '~', '`'},StringSplitOptions.RemoveEmptyEntries);
            Reverse(words, marks);
        }

        private static void Reverse(string[] words, string[] marks)
        {
            Array.Reverse(words);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < marks.Length; i++)
            {
                result.Append(words[i]);
                result.Append(marks[i]);
            }
            Print(result);
        }

        private static void Print(StringBuilder result)
        {
            Console.WriteLine(result.ToString());
        }
    }
}
