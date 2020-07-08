using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            byte summand1 = 1, summand2 = 2;
            int sum = summand1 + summand2;
            Console.WriteLine(sum);

            byte minuend = 255, subtrahend = 3;
            int difference = minuend - subtrahend;
            Console.WriteLine(difference);

            byte factor1 = 2, factor2 = 3;
            int product = factor1 * factor2;
            Console.WriteLine(product);

            byte dividend = 5, divisor = 2;
            int quotient = 0, remainder = 0;
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}
