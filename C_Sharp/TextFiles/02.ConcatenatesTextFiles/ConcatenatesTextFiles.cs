using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatenatesTextFiles
{
    class ConcatenatesTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("first.txt");
            StreamWriter writer = new StreamWriter("result.txt", false, Encoding.GetEncoding("windows-1251"));
            string line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            reader = new StreamReader("second.txt");
            writer = new StreamWriter("result.txt", true, Encoding.GetEncoding("windows-1251"));
            line = reader.ReadLine();
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
