using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_MethodsRecursiveFactorial
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        } 
         
        static void Main()
        {
            int factorial = Factorial(5);
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
