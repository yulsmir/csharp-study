using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MethodsOptionalParameters
{
    class Program
    {
        static void Operation(string value1 = "val", int value2 = 10, double value3 = 12.2)
        {
            Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
        }
        static void Main()
        {
            Operation();
            Operation("val");
            Operation("val", 10);
            Operation("val", 10, 12.2);

            //Operation("Alex", (int)12.2);

            Operation("val", value3: 12.2);
            Operation(value2: 33, value3: 12.2);

            Console.ReadKey();
        }
    }
}
