using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncryptionKey
{
    class Program
    {
        static StringBuilder message;
        static void Main(string[] args)
        {
            Console.Write("Enter a cipher: ");
            string cipher = Console.ReadLine();
            Console.Write("Enter a string to be encoded: ");
            string text = Console.ReadLine();
            message = new StringBuilder();
            Encode(text, cipher);
            Decode(message.ToString(), cipher);
            Print();
        }

        private static void Decode(string message, string cipher)
        {
            Encode(message, cipher);
        }

        private static void Print()
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();
        }

        private static void Encode(string text, string cipher)
        {
            message = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                message.Append((char)(text[i] ^ cipher[i % cipher.Length]));
            }
        }
    }
}
