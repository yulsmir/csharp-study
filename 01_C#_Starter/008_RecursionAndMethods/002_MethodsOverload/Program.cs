using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_MethodsOverload
{
    class Program
    {
        static void Operation()
        {
            Operation("val", 10, 12.2);
        }
        static void Operation(string value1)
        {
            Operation(value1, 10, 12.2);
        }

        static void Operation(string value1, int value2)
        {
            Operation(value1, value2, 12.2);
        }

        static void Operation(string value1, int value2, double value3)
        {
            Console.WriteLine("{0},{1},{2}", value1, value2, value3);
        }
        static void Main()
        {
            Operation();
            Operation("val");
            Operation("val", 10);
            Operation("val", 10, 12.2);
            Console.ReadKey();
        }
    }
}
