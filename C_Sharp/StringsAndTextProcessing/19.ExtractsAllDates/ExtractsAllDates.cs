using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _19.ExtractsAllDates
{
    class ExtractsAllDates
    {
        static void Main(string[] args)
        {
            string text = "12.9.2011 . ... 12.7.2013 12.4. 2013 17.14.12.9.";
            string[] arr = text.Split(new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
                                                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                   '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                   'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                   'y', 'z','*', '/', '=', '~', '`','(',')', ' '});          
            CheckValidDate(arr);
        }

        private static void PrintResult(StringBuilder result)
        {
            string[] final = result.ToString().Split(' ');
            for (int i = 0; i < final.Length; i++)
            {               
                DateTime date = new DateTime();
                if (DateTime.TryParse(final[i], out date))
                {
                    Console.WriteLine(date.ToString("yyyy-MM-dd"));
                }
            }
        }

        private static void CheckValidDate(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                StringBuilder result = new StringBuilder();
                int countDay = 0;
                int countMonth = 0;
                int countYear = 0;
                int index = 0;
                string current = arr[i].ToString();
                if (current.Length < 8)
                {
                    continue;
                }
                for (int j = 0; j < current.Length; j++)
                {
                    for (int k = 0; ; k++)
                    {
                        if (current[k] == '.')
                        {
                            index = k;
                            break;
                        }
                        else
                        {
                            countDay++;
                        }
                    }
                    if (countDay > 2)
                    {
                        break;
                    }
                    for (int m = index + 1; ; m++)
                    {
                        if (current[m] == '.')
                        {
                            index = m;
                            break;
                        }
                        else
                        { 
                            countMonth++;
                        }                      
                    }
                    if (countMonth > 2)
                    {
                        break;
                    }
                    for (int n = index + 1; n < current.Length; n++)
                    {
                        if (current[n] == '.')
                        {
                            break;
                        }
                        else
                        {
                            countYear++;
                        }
                    }
                    if ((countDay >= 1 && countDay <= 2) && (countMonth >= 1 && countMonth <= 2) && (countYear == 4))
                    {
                        result.Append(current);
                        PrintResult(result);
                        break;
                    }
                }
            }
        }
    }
}
