using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_ArraysParams
{
    class Program
    {
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main()
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0);
            Console.ReadKey();
        }
    }
}
