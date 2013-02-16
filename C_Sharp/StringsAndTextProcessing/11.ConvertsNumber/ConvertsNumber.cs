using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertsNumber
{
    class ConvertsNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            int value = Convert.ToInt32(number);
            ConvertToDecimal(value);
            ConvertToHex(value);
            ConvertToPercentage(value);
            ConvertToScientificNotation(value);
        }

        private static void ConvertToScientificNotation(int value)
        {
            string scientificNot = String.Format("{0:E}", value);
            Console.WriteLine(scientificNot.PadLeft(15, ' '));
        }

        private static void ConvertToPercentage(int value)
        {
            string percentage = String.Format("{0:P}", value);
            Console.WriteLine(percentage.PadLeft(15, ' '));
        }

        private static void ConvertToDecimal(int value)
        {
            string dec = value.ToString();
            Console.WriteLine(dec.PadLeft(15, ' '));
        }

        private static void ConvertToHex(int value)
        {
            string hex = String.Format("{0:X}", value);
            Console.WriteLine(hex.PadLeft(15, ' '));
        } 
    }
}
