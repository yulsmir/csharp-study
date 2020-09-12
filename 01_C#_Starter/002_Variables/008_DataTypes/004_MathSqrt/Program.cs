using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_MathSqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 256;
            double result = Math.Sqrt(x);

            Console.WriteLine("Square root equals: ");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
