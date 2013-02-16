using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09.DeletesOddLines
{
    class DeletesOddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("test.txt");
            List<string> even = new List<string>();
            string line = reader.ReadLine();
            int lineNumber = 1;
            using (reader)
            {
                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        even.Add(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
            StreamWriter writer = new StreamWriter("test.txt");
            using (writer)
            {
                for (int i = 0; i < even.Count; i++)
                {
                    writer.WriteLine(even[i]);
                }
            }
        }
    }
}
