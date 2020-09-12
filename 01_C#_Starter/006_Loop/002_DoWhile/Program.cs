using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);
            }
            while (counter < 3);
            Console.WriteLine("{0} iterations made.", counter);
            Console.ReadKey();
        }
    }
}
