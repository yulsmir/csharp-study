using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003__RadiusCount
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = 2.56;

            double square = pi * (Math.Pow(r, 2));
            Console.WriteLine(square);
            Console.ReadKey();
        }
    }
}
