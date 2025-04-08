using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arrays
{
    class SingleLine
    {
        public static void Run()
        {
            string inputLine = Console.ReadLine(); // чете от конзолата
            string[] items = inputLine.Split(","); // маха запетаята 
            int[] arr = items.Select(int.Parse).ToArray();// преобразува

            foreach(int element in arr)
            {
                Console.Write($" { element}");
            }
        }
    }
}
