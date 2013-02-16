using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintName
{
    class PrintName
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();
            PrintPersonsName(name);
        }
        static void PrintPersonsName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
