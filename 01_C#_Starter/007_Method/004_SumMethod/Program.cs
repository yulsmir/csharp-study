using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_SumMethod
{
    class Program
    {

        static int Sum(int summand1, int summand2, int summand3)
        {
            return summand1 + summand2 + summand3;
        }

        static void Main()
        {
            int summand1 = 10, summand2 = 25, smmand3 = 155;
            int sum = Sum(summand1, summand2, summand3);
            Console.WriteLine("{0} + {1} + {2} = {3}", summand1, summand2, summand3, sum);

            Console.ReadKey();
        }
    }
}
