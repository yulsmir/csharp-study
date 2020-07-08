using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value1 = 0, value2 = 1;
            bool result;

            result = value1 < value2;
            Console.WriteLine(result);

            result = value1 > value2;
            Console.WriteLine(result);
            
            result = value1 >= value2;
            Console.WriteLine(result);

            result = value1 <= value2;
            Console.WriteLine(result);

            result = value1 == value2;
            Console.WriteLine(result);

            result = value1 != value2;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
