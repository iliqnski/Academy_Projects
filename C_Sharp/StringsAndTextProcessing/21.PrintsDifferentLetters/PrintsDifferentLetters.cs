using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.PrintsDifferentLetters
{
    class PrintsDifferentLetters
    {
        class CountTheLetters
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a string: ");
                string inputString = Console.ReadLine();
                char[] letters = new char[] {'a','A','b','B','c','C','d','D','e','E','f','F','g','G','h','H','i','I','j','J','k','K',
                                     'l','L','m','M','n','N','o','O','p','P','q','Q','r','R','s','S','t','T','u','U',
                                     'v','V','w','W','x','X','y','Y','z','Z'};
                int[] counter = new int[52];
                for (int i = 0; i < inputString.Length; i++)
                {
                    char current = inputString[i];
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (current == letters[j])
                        {
                            counter[j]++;
                        }
                    }
                }
                for (int i = 0; i < counter.Length; i++)
                {
                    if (counter[i] != 0)
                    {
                        Console.WriteLine("Letter {0} - {1} time(s)", letters[i], counter[i]);
                    }
                }
            }
        }
    }
}
