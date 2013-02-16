using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplacesTags
{
    class ReplacesTags
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            text = text.Replace("<a href=\"http://academy.telerik. com\">", "[URL=http://academy.telerik. com]");
            text = text.Replace("</a>", "[/URL]");
            text = text.Replace("<a href=\"www.devbg.org\">", "[URL=www.devbg.org]");
            Console.WriteLine(text);
        }
    }
}
