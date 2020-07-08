using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable2 = 0;
            variable2 = variable2 + 5;
            variable2 += 5;

            uint variable3 = 0;
            variable3 = variable3 - 5;
            variable3 -= 5;

            long variable4 = 0;
            variable4 = variable4 * 5;
            variable4 *= 5;

            ulong variable5 = 0;
            variable5 = variable5 / 5;
            variable5 /= 5;

            long variable6 = 0;
            variable6 = variable6 % 5;
            variable6 %= 5;

            Console.WriteLine(variable2);
            Console.WriteLine(variable3);
            Console.WriteLine(variable4);
            Console.WriteLine(variable5);
            Console.WriteLine(variable6);

            Console.ReadKey();
        }
    }
}
