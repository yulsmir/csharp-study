using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, max = 0;
            max = (a > b) ? a : b;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
