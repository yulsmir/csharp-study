using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ArrayTwoDimensional
{
    class Program
    {
        static void Main()
        {
            int[,] array = {
                             { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 },
                           };

            Console.WriteLine(array);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
