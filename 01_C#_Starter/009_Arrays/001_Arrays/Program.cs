using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            Console.ReadKey();
        }
    }
}
