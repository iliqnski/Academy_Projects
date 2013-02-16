using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.ReplacesSubstring
{
    class ReplacesSubstring
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("test.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            string line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(line.Replace("start", "finish"));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
