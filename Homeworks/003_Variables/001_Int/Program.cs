using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            
            float result1 = x += y - x++ * z;
            float result2 = z = --x - y * 5;
            float result3 = y /= x + 5 % z;
            float result4 = z = x++ + y * 5;
            float result5 = x = y - x++ * z;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            Console.ReadKey();
        }
    }
}
