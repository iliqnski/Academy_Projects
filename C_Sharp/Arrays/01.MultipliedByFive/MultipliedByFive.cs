using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MultipliedByFive
{
    class MultipliedByFive
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[20];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = 5 * i;
                Console.WriteLine("{0} ", myArr[i]);
            }
        }
    }
}
