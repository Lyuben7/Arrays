using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ReadingArray
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter numbers for the array: ");
                arr[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(arr[i]);
            }
            Console.Write("The numbers in array are: ");
            foreach(int element in arr) 
            {
                Console.Write($" {element},");
            }
        }
    }
}
