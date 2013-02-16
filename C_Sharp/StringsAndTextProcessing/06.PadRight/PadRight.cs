using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PadRight
{
    class PadRight
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            Console.WriteLine(characters = characters.PadRight(20, '*'));
        }
    }
}
