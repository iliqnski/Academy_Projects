using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _12.RemovesWords
{
    class RemovesWords
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader1 = new StreamReader("words.txt");
                StreamReader reader2 = new StreamReader("text.txt");
                List<string> forbidden = new List<string>();
                List<string> text = new List<string>();
                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();
                using (reader1)
                {
                    while (line1 != null)
                    {
                        forbidden.Add(line1);
                        line1 = reader1.ReadLine();
                    }
                }
                using (reader2)
                {
                    while (line2 != null)
                    {
                        text.Add(line2);
                        line2 = reader2.ReadLine();
                    }
                }
                StreamWriter writer = new StreamWriter("text.txt");
                using (writer)
                {
                    for (int i = 0; i < text.Count; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < forbidden.Count; j++)
                        {
                            if (text[i] == forbidden[j])
                            {
                                writer.WriteLine(" ");
                                break;
                            }
                            else
                            {
                                count++;
                            }
                        }
                        if (count == forbidden.Count)
                        {
                            writer.WriteLine(text[i]);
                        }
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("{0}: {1}", exception.GetType().Name, exception.Message);
            }
        }
    }
}
