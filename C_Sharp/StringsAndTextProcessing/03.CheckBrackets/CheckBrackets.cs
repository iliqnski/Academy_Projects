using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckBrackets
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            string expression = Console.ReadLine();
            CheckCorrectlyBrackets(expression);
        }

        private static void CheckCorrectlyBrackets(string expression)
        {
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' && counter >= 0)
                {
                    counter++;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("THe brackets are put correctly!");
            }
            else
            {
                Console.WriteLine("The brackets are not put correctly!");
            }

        }
    }
}
