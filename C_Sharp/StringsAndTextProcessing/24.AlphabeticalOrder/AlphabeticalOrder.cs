using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.AlphabeticalOrder
{
    class AlphabeticalOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of words separated by spaces: ");
            string text = Console.ReadLine();
            char[] separator = {' '};
            string[] result = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(result);
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    } 
}
