using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("This is number {0}", a);

            int b = 2, c = 3;
            Console.WriteLine("These are numbers {0} and {1}", b, c);
            Console.WriteLine("These are numbers backwards {1} and {0}", b, c);

            Console.ReadKey();
        }
    }
}
