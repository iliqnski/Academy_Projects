using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10.ExtractsFromXML
{
    class ExtractsFromXML
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("result.txt");
            string line = reader.ReadLine();
            bool openTag = false;
            List<string> result = new List<string>();
            using (reader)
            {
                while (line != null)
                {
                    for (int i = 0; i < line.Length - 1; i++)
                    {
                        if (line[i] == '<')
                        {
                            openTag = true;
                        }
                        if (openTag == false)
                        {
                            result.Add(line[i].ToString());
                            if (line[i + 1] == '<')
                            {
                                result.Add(" ");
                            }
                        }
                        if (line[i] == '>')
                        {
                            openTag = false;
                        }                  
                    }
                    line = reader.ReadLine();
                }
            }
            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    writer.Write(result[i]);
                }
            }
        }
    }
}
