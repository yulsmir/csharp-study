using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Method
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main()
        {
            int sum = Add(2, 3);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
