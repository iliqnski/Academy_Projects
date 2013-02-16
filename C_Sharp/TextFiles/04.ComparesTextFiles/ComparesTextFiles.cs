using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.ComparesTextFiles
{
    class ComparesTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader firstReader = new StreamReader("first.txt");
            StreamReader secondReader = new StreamReader("second.txt");
            string firstReaderLine = firstReader.ReadLine();
            string secondReaderLine = secondReader.ReadLine();
            int lineNumber = 1;
            using (firstReader)
            {
                using (secondReader)
                {
                    while (firstReaderLine != null && secondReaderLine != null)
                    {
                        if (firstReaderLine == secondReaderLine)
                        {
                            Console.WriteLine("Lines number \"{0}\" are equal!", lineNumber);
                        }
                        lineNumber++;
                        firstReaderLine = firstReader.ReadLine();
                        secondReaderLine = secondReader.ReadLine();
                    }
                }
            }
        }
    }
}
