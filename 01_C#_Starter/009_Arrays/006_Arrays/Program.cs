using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Arrays
{
    class Program
    {
        static void Main()
        {
            int[,] array = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = i * j + 2;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0} ", array[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
