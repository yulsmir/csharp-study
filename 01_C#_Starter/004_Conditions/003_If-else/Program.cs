using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 2;
            if (a < b)
            {
                Console.WriteLine("a < b");
            }

            else if (a > b)
            {
                Console.WriteLine("a > b");
            }

            else
            {
                Console.WriteLine("a == b");
            }
            Console.ReadKey();
        }
    }
}
