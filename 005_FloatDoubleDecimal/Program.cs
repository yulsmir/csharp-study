using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float variable1 = 0.12345678901234567890f;
            double variable2 = 0.12345678901234567890d;
            decimal variable3 = 0.12345678901234567890m;

            Console.WriteLine(variable1);
            Console.WriteLine(variable2);
            Console.WriteLine(variable3);

            Console.ReadKey();
        }
    }
}
