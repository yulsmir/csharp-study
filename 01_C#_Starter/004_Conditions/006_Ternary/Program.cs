using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = -5, max = 0;
            max = a > b ? c = a : c = b;
            Console.WriteLine(max);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
