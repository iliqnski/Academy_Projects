using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortsArrayOfStrings
{
    class SortsArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a size: ");
            int size = int.Parse(Console.ReadLine());
            List<string> myList = new List<string>();
            Console.WriteLine("Enter the strings:");
            for (int i = 0; i < size; i++)
            {
                myList.Add(Console.ReadLine());
            }
            foreach (string str in Sort(myList))
            {
                Console.WriteLine(str);
            }
        }
        static IEnumerable<string> Sort(IEnumerable<string> a)
        {
            var sorted = from str in a
                         orderby str.Length ascending
                         select str;
            return sorted;
        }
    }
}
