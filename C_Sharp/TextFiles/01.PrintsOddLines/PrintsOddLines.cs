using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintsOddLines
{
    class PrintsOddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Example.txt");
            string line = reader.ReadLine();
            int lineNumber = 0;
            while (line != null)
            {
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("lineNumber {0} - {1}", lineNumber, line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
                
            }
            reader.Close();
        }
    }
}
