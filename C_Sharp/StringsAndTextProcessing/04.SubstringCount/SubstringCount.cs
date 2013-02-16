using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubstringCount
{
    class SubstringCount
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter a word from the string you wish to search: ");
            string keyword = Console.ReadLine();
            FindQuote(str, keyword);
        }
        private static void FindQuote(string str, string keyword)
        {
            str = str.ToLower();
            int index = str.IndexOf(keyword);
            int counter = 0;
            while (index != -1)
            {
                counter++;
                index = str.IndexOf(keyword, index + 1);
            }
            Console.WriteLine("{0} times", counter);
        }
    }
}
