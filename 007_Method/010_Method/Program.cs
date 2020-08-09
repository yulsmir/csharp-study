using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Method
{
    class Program
    {
        static void AddTwo(int a)
        {
            a = a + 2;
            Console.WriteLine("Value of int a = {0}", a);
        }
        static void Main()
        {
            Console.WriteLine("Enter the number");
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Value result = {0}", result);

            AddTwo(result);
            Console.WriteLine("Value of result = {0}", result);

            Console.ReadKey();
        }
    }
}
