using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Method
{
    //Ref = in/out
    
    class Program
    {
        static int Method(ref int a)
        {
            int b = a * 2;
            a = 10;
            return b;
        }
        static void Main()
        {
            int operand = 25;
            int result = Method(ref operand);
            Console.WriteLine("{0}; {1};", operand, result);
            Console.ReadKey();
        }
    }
}
