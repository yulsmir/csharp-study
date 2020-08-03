using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_SumMethod
{
    class Program
    {

        static int Sum(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        static void Main()
        {
            int summand1 = 10, summand2 = 25;
            int sum = Sum(summand1, summand2);
            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            Console.ReadKey();
        }
    }
}
