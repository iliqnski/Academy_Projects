using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13.ReadsWords
{
    class ReadsWords
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader wordsReader = new StreamReader("words.txt");
                StreamReader textReader = new StreamReader("text.txt");
                StreamWriter result = new StreamWriter("result.txt");
                List<string> wordsList = new List<string>();
                List<string> textList = new List<string>();
                List<string> resultList = new List<string>();
                List<int> counter = new List<int>();
                string textLine = textReader.ReadLine();
                string wordsLine = wordsReader.ReadLine();
                using (wordsReader)
                {
                    while (wordsLine != null)
                    {
                        wordsList.Add(wordsLine);
                        wordsLine = wordsReader.ReadLine();
                    }
                }
                using (textReader)
                {
                    while (textLine != null)
                    {
                        textList.Add(textLine);
                        textLine = textReader.ReadLine();
                    }
                }
                for (int i = 0; i < wordsList.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < textList.Count; j++)
                    {
                        if (wordsList[i] == textList[j])
                        {
                            count++;
                        }
                        if (j == textList.Count - 1)
                        {
                            counter.Add(count);
                            resultList.Add(wordsList[i]);
                        }
                    }
                }
                using (result)
                {
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        result.WriteLine("{0} time(s) - {1}", counter[i], resultList[i]);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("{0}: {1}", exception.GetType().Name, exception.Message);
            }
        }
    }
}
