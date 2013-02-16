using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberOfDays
{
    class NumberOfDays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start date <YYYY-MM-DD>: ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter end date <YYYY-MM-DD>: ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(CountDays(startDate,endDate));
        }
        private static int CountDays(DateTime startDate, DateTime endDate)
        {
            int count = 0;
            while (startDate < endDate)
            {
                count++;
                startDate = startDate.AddDays(1);
            }
            return count;
        }
    }
}
