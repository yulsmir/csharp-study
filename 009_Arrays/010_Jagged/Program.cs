using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Jagged
{
    class Program
    {
        static void Main()
        {
            int[][] jagged = new[]
            {
                new int [] { 1, 2 },
                new int [] { 1, 2, 3, 4, 5, 6 },
                new int [] { 1, 2, 3 }
            };
            for (int i = 0; i < jagged.Length; ++i)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
