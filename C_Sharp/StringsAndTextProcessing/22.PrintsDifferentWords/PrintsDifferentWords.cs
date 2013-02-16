using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.PrintsDifferentWords
{
    class PrintsDifferentWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            string[] splitted = inputString.Split(' ');
            int[] counter = new int[splitted.Length + 1];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < splitted.Length; i++)
            {
                string current = splitted[i];
                for (int j = i; j < splitted.Length; j++)
                {
                    if (current == splitted[j].ToString() && current != " ")
                    {
                        result.Append(current);
                        result.Append(' ');
                        counter[j]++;
                    }
                }
            }
            string[] final = result.ToString().Split(' ');
            for (int i = 0; i < final.Length; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine("Word {0} - {1} time(s)", final[i], counter[i]);
                }
            }
        }
    }
}
