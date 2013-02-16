using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int start = 2;
            int end = 1000000;
            int current = start;
            List<int> primeList = new List<int>();
            for (int i = start; i <= end; i++)
            {
                primeList.Add(i);
            }
            while (true)
            {
                current += start;
                primeList.Remove(current);
                if (current >= end - 1)
                {
                    start++;
                    current = start;
                }
                if (start * 2 > end)
                {
                    break;
                }
            }
            foreach (var i in primeList)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
