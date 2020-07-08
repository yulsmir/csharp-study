using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_LocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 1;
                Console.WriteLine(a);
            }
            
            {
                int a = 2;
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
