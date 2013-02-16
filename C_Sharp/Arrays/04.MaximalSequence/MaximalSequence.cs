using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());
            if (size == 0)
            {
                Console.WriteLine("You have entered incorrect data!");
                return;
            }
            int[] myArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            //int[] myArr = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            //int size = 10;
            int count = 1;
            int bestCount = 0;
            List<int> myList = new List<int>();
            for (int i = 0; i < size - 1; i++)
            {
                if (myArr[i] == myArr[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        myList = new List<int>();
                        for (int j = 0; j < bestCount; j++)
                        {
                            myList.Add(myArr[i]);
                        }
                    }              
                }
                else
                {
                    count = 1; 
                }
            }
            if (bestCount == 0)
            {
                myList.Add(myArr[0]);
            }
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write("{0}", myList[i]);
                if (i != myList.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
