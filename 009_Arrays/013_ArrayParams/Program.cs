using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_ArrayParams
{
    class Program
    {
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main()
        {
            ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            Console.ReadKey();
        }
    }
}
