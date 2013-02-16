using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ExtractsEmailAddresses
{
    class ExtractsEmailAddresses
    {
        static void Main(string[] args)
        {
            string text = "Please contact us by phone (+359 222 222 222) or by example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string[] arr = text.Split(' ');
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                string current = arr[i].ToString();
                int countId = 0;
                int countHost = 0;
                int countDomain = 0;
                for (int j = 0; j < current.Length; j++)
                {
                    if (current[j] == '@')
                    {
                        int index = j;
                        for (int k = 0; k < index; k++)
                        {
                            countId++;
                        }
                        for (int m = index + 1; m < current.Length; m++)
                        {
                            if (current[m] == '.')
                            {
                                index = m;
                                break;
                            }
                            countHost++;
                        }
                        for (int n = index + 1; n < current.Length; n++)
                        {
                            countDomain++;
                        }
                        if (countId >= 6 && countHost >= 3 && countDomain >= 2)
                        {
                            result.Append(current);
                            result.Append(' ');
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (result[i] == ' ')
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
