using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Welcome onboard!");
        }
    }
    class Program
    {
        static void Main()
        {
            new MyClass().Method();
            Console.ReadKey();
        }
    }
}
