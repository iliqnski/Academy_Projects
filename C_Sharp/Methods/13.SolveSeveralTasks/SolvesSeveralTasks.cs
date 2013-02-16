using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveSeveralTasks
{
    class SolvesSeveralTasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: \n 1 for reversing a number \n 2 for calculating the average of a sequence of integers \n 3 for solving: a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.Write("Please enter a positive number to be reversed: ");
                    decimal num = decimal.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        string numStr = num.ToString();
                        List<string> reversed = new List<string>();
                        ReversesNumber(numStr, reversed);
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect data!");
                    }
                    break;
                case 2: Console.Write("Please, enter a number for a sequence (n > 0): ");
                    int size = int.Parse(Console.ReadLine());
                    if (size > 0)
                    {
                        int[] arr = new int[size];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write("arr[{0}] = ", i);
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        CalculateAverage(arr);
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect data!");
                    }
                    break;
                case 3: Console.Write("Enter a value for a (a != 0): ");
                    int a = int.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        Console.Write("Enter a value for b: ");
                        int b = int.Parse(Console.ReadLine());
                        SolveEquation(a, b);
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect data!");
                    }
                    break;
            }
        }
        static void SolveEquation(int a, int b)
        {
            double result = 0;
            result =  -(double)b / a;
            Console.WriteLine("x = {0}", result);
        }
        static void CalculateAverage(int[] arr)
        {
            decimal average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }
            Console.WriteLine("The average of the sequence is: {0}", average / arr.Length);
        }
        static void ReversesNumber(string revNum, List<string> reversed)
        {
            for (int i = revNum.Length - 1; i >= 0; i--)
            {
                reversed.Add(revNum[i].ToString());
            }
            PrintReversedNumber(reversed);
        }
        static void PrintReversedNumber(List<string> reversed)
        {
            Console.WriteLine("The reversed number is: ");
            foreach (var number in reversed)
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }
    }
}
