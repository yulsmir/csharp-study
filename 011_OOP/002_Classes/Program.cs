using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
    class MyClass
    {
        public string field;
        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.field = "Hello world!";
            Console.WriteLine(instance.field);
            instance.Method();

            Console.ReadKey();
        }
    }
}
