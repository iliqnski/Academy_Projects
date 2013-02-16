using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.SortsListOfStrings
{
    class SortsListOfStrings
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            List<string> result = new List<string>();
            string line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        result.Add(line);
                        line = reader.ReadLine();
                    }
                    result.Sort();
                    for (int i = 0; i < result.Count; i++)
                    {
                        writer.WriteLine(result[i]);
                    }
                }
            }
        }
    }
}
