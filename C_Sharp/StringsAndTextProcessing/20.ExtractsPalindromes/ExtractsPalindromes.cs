using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ExtractsPalindromes
{
    class ExtractsPalindromes
    {
        static void Main(string[] args)
        {
            string text = "ABBA lamal exe ata. aaattaa saas abvs";
            string[] splitted = text.Split(' ');
            CheckPalindromes(splitted);
        }

        private static void CheckPalindromes(string[] splitted)
        {         
            for (int i = 0; i < splitted.Length; i++)
            { 
                StringBuilder result = new StringBuilder();
                bool palindrom = true;
                string current = splitted[i];
                for (int j = 0; j < current.Length / 2; j++)
                {
                    if (current[j] != current[current.Length - j - 1])
                    {
                        palindrom = false;
                    }
                }
                if (palindrom == true)
                {
                    result.Append(current);
                    PrintResult(result);
                }
            }
        }

        private static void PrintResult(StringBuilder result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
