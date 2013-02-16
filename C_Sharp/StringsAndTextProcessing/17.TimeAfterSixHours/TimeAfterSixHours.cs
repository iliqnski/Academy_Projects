using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.TimeAfterSixHours
{
    class TimeAfterSixHours
    {
        static void Main(string[] args)
        {         
            string dateTime = "2013.2.09 05:45:00";
            DateTime dateTimeNew = DateTime.Parse(dateTime).AddHours(6).AddMinutes(30);
            Console.Write(dateTimeNew.ToString("dddd", new CultureInfo("bg-BG")) + " ");
            Console.Write(dateTimeNew);
            Console.WriteLine();
        }
    }
}
