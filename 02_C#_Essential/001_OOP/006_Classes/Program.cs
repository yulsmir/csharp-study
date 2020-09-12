using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("MyClass' method is called");
        }
    }

    class MyClass2
    {
        public void CallMethod(MyClass my)
        {
            my.Method();
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);
            Console.ReadKey();
        }
    }
}
