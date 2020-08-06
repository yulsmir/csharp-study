using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Method
{
    class Program
    {
        static int Method(out int a)
        {
            a = 2;
            return a * 2;
        }
        static void Main()
        {
            int operand;
            int result = Method(out operand);
            Console.WriteLine("{0}; {1};", operand, result);
            Console.ReadKey();
        }
    }
}
