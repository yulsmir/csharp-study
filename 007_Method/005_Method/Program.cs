using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Method
{
    class Program
    {
        static bool And(bool a, bool b)
        {
            return a && b;
        }
        static void Main(string[] args)
        {
            bool operand1 = true, operand2 = true;
            bool result = And(operand1, operand2);
            Console.WriteLine("{0} && {1} = {2}", operand1, operand2, result);
            Console.ReadKey();
        }
    }
}
