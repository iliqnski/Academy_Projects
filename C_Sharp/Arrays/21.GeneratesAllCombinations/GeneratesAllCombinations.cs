using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task01
{
    class GeneratesAllCombinations
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] arrLoops;
        static void Main(string[] args)
        {
            Console.Write("n = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            arrLoops = new int[numberOfLoops];
            GenLoops(0, 1);
        }
        static void GenLoops(int index, int start)
        {
            if (index == numberOfLoops)
            {
                Print();
                return;
            }
            for (int i = start; i <= numberOfIterations; i++)
            {
                arrLoops[index] = i;
                GenLoops(index + 1, i + 1);
            }
        }
        static void Print()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", arrLoops[i]);
            }
            Console.WriteLine();
        }
    }
}