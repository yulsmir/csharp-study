using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ArraysWithCounter
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
