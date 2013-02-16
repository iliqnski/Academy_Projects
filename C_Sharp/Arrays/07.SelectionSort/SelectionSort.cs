using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int smallest = 0;
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                smallest = arr[i];
                temp = i + 1;
                while (temp < size)
                {
                    if (arr[temp] < smallest)
                    {
                        smallest = arr[temp]; 
                        arr[temp] = arr[i];  
                        arr[i] = smallest;                       
                    }
                    temp++;
                }                        
            }
            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("arr[{0}] = {1}",i ,arr[i]);
            }
        }
    }
}
