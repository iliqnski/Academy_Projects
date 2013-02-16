using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.DeletesPrefix
{
    class DeletesPreffix
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            string line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
