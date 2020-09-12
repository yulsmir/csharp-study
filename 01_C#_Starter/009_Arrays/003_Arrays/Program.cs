using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
