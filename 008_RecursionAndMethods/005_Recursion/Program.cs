using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Recursion
{
    class Program
    {
        static int Calculate(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Calculate(b, a % b);
        }

        static void Main()
        {
            Console.WriteLine("Calculate greatest common divider of two numbers:");
            int a = 15, b = 33;
            Console.WriteLine("a = {0}, b = {1}, div = {2}", a, b, Calculate(a, b));
            Console.ReadKey();
        }

    }
}
