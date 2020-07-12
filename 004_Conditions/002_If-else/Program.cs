using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11, b = 2;
            if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else 
            {
                Console.WriteLine("a is not less than b");
            }

            Console.ReadKey();
        }

    }
}
