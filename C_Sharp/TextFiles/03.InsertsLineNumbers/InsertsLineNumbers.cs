using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.InsertsLineNumbers
{
    class InsertsLineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("reader.txt");
            StreamWriter writer = new StreamWriter("writer.txt");
            string line = reader.ReadLine();
            int lineNumber = 1;
            using (reader)
            {
                using (writer)
                {
                    while (line != null)
                    {
                        
                        writer.WriteLine("{0} - {1}", lineNumber, line);
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
