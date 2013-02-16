using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Task15
{
    class ReadsIndexes
    {
        static void Main(string[] args)
        {
            string[] array = new string[]{"a","b","c","d","e","f",
                                          "g","h","i","j","k","l",
                                          "m","n","o","p","q","r",
                                          "s","t","u","v","w","x",
                                          "y","z"};
            Console.Write("Enter a word: ");
            string name = Console.ReadLine();
            string[] word = new string[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                word[i] = name[i].ToString();
                for (int j = 0; j < array.Length; j++)
                {
                    if (word[i] == array[j])
                    {
                        Console.Write("{0} ", j);
                    }
                }
            }
        }
    }
}
