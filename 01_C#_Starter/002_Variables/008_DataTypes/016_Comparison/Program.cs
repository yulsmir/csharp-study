using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;

            int a = 1;
            float b = 2.0f;
            result = a < b;

            string c = "Hello";

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
