using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractsAllSentences
{
    class ExtractsAllSentences
    {
        static StringBuilder result;
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] concatenated = text.Split('.');
            ExtractSentences(concatenated);
        }

        private static void ExtractSentences(string[] sentences)
        {
            string keyword = "We";
            result = new StringBuilder();
            for (int i = 0; i < sentences.Length; i++)
            {
                string subString = sentences[i].ToString();
                int index = subString.IndexOf(keyword);
                for (int j = 0; j < subString.Length; j++)
                {
                    if (index != -1)
                    {
                        if (index != 0 && index + keyword.Length < subString.Length && subString[index - 1].ToString() == " " && subString[index + keyword.Length].ToString() == " ")
                        {
                            result.Append(sentences[i]);
                        }
                        if (index + keyword.Length == subString.Length && subString[index - 1].ToString() == " ")
                        {
                            result.Append(sentences[i]);
                        }
                        if (index == 0 && subString[index + keyword.Length].ToString() == " ")
                        {
                            result.Append(sentences[i]);
                        }
                        index = subString.IndexOf(keyword, index + 2);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            PrintResult();
        }
        private static void PrintResult()
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
