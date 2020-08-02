using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ForCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
            }
            Console.ReadLine();
        }
    }
}
