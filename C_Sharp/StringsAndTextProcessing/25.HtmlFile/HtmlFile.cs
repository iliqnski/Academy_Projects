using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.HtmlFile
{
    class HtmlFile
    {
        static void Main(string[] args)
        {
            string html = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerikn Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            bool openTag = false;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < html.Length; i++)
            {
                if (html[i] == '<')
                {
                    openTag = true;
                } 
                if (openTag == false)
                {
                    result.Append(html[i]);
                }
                if (html[i] == '>')
                {
                    openTag = false;
                    result.Append(' ');
                }              
            }
            string final = result.ToString();
            foreach (var word in final)
            {
                Console.Write(word);
            }
            Console.WriteLine();
        }
    }
}
