using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChangesToUppercase
{
    class ChangesToUppercase
    {
        static void Main(string[] args)
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            ToUpper(str);
        }
        private static void ToUpper(string str)
        {
            int start = 0;
            int end = 0;
            List<string> correct = new List<string>();
            string keyword = "<upcase>";
            int index = str.IndexOf(keyword);
            for (int i = 0; i < str.Length; i++)
            {
                correct.Add(str[i].ToString());
            }
            while (index != -1)
            {
                start = index;
                keyword = "</upcase>";
                index = str.IndexOf(keyword, index + 1);
                end = index;
                for (int i = start + 8; i < end; i++)
                {
                    correct[i] = correct[i].ToUpper();
                }
                keyword = "<upcase>";
                index = str.IndexOf(keyword, index + 1);
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < correct.Count; i++)
            {
                result.Append(correct[i]);
            }
            result.Replace("<upcase>", "");
            result.Replace("</upcase>", "");
            PrintResult(result);
        }
        private static void PrintResult(StringBuilder result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
