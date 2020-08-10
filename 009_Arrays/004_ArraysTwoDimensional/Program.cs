using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ArraysTwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = i * j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
