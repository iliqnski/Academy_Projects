using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParsesURL
{
    class ParsesURL
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();
            Separate(url, protocol, server, resource);
            PrintResult(protocol, server, resource);
        }
        private static void PrintResult(StringBuilder protocol, StringBuilder server, StringBuilder resource)
        {
            for (int i = 0; i < protocol.Length; i++)
            {
                Console.Write(protocol[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < server.Length; i++)
            {
                Console.Write(server[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < resource.Length; i++)
            {
                Console.Write(resource[i]);
            }
            Console.WriteLine();
        }
        private static void Separate(string url, StringBuilder protocol, StringBuilder server, StringBuilder resource)
        {
            string keyword = ":";
            int index = url.IndexOf(keyword);
            if (index != -1)
            {
                for (int i = 0; i < index; i++)
                {
                    if (i == 0)
                    {
                        protocol.Append("\"");
                    }
                    protocol.Append(url[i]);
                    if (i == index - 1)
                    {
                        protocol.Append("\"");
                    }

                }
            }
            keyword = "//";
            index = url.IndexOf(keyword);
            if (index != -1)
            {
                for (int i = index + 2; ; i++)
                {
                    if (i == index + 2)
                    {
                        server.Append("\"");
                    }
                    if (url[i] == '/')
                    {
                        server.Append("\"");
                        break;
                    }
                    server.Append(url[i]);
                }
            }
            keyword = "/";
            index = url.IndexOf(keyword, 7);
            for (int i = index; i < url.Length; i++)
            {
                if (i == index)
                {
                    resource.Append("\"");
                }
                resource.Append(url[i]);
                if (i == url.Length - 1)
                {
                    resource.Append("\"");
                }
            }
        }
    }
}
