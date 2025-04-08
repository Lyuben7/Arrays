using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ReverseAnArray
    {
        public static void Run()
        {
            Console.Write("Enter chars: ");
            string[] array = Console.ReadLine().Split(',');
            Array.Reverse(array);
            Console.Write("Reversed: "+ string.Join(" ", array));
        }
    }
}

