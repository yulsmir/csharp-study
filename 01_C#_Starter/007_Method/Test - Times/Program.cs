using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test___Times
{
    class Program
    {
        static ulong power(uint x, uint n)
        {
            ulong result = x;

            for (int i = 1; i < n; i++)
            {
                result *= x;
            }
            if (n == 0)
            {
                return 1;
            }
            return result;
        }
        static void Main()
        {
            uint operand1 = 5;
            uint operand2 = 2;
            ulong result = power(operand1, operand2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
