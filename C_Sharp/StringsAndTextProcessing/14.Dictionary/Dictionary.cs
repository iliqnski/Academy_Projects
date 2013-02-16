using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");
            Console.Write("Enter a word from the dictionary: ");
            string word = Console.ReadLine();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine(dictionary[word]);
            }         
        }
    }
}
