using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GeneratesAllVariations
{
    class GeneratesAllVariations
    {
        static int k;
        static int n;
        static int[] arrLoops;
        static void Main(string[] args)
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            arrLoops = new int[k];
            GenLoops(0);
        }
        static void GenLoops(int index)
        {
            if (index == k)
            {
                Print();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                arrLoops[index] = i;
                GenLoops(index + 1);
            }
        }
        static void Print()
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arrLoops[i]);
            }
            Console.WriteLine();
        }
    }
}
