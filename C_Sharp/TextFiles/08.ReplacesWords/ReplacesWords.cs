using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _08.ReplacesWords
{
    class ReplacesWords
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
                        int index = line.IndexOf("start");
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (index == 0 && line.Length == 5)
                            {
                                writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                            }
                            if (index != -1 && index != 0)
                            {
                                if (line[index - 1] == ' ')
                                {
                                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                                    break;
                                }
                                else if (index == line.Length - 5)
                                {
                                    writer.WriteLine(line);
                                }
                            }
                            index = line.IndexOf("start", index + 1);
                            if (index == -1)
                            {
                                break;
                            }
                        }
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
