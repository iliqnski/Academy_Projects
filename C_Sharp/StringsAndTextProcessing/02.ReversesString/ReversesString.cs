using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReversesString
{
    class ReversesString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(Reverse(str));
        }

        private static string Reverse(string str)
        {
            StringBuilder sB = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sB.Append(str[i]);
            }
            return sB.ToString();
        }
    }
}
