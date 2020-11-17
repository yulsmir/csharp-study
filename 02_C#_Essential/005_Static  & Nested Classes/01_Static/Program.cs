using System;

namespace _01_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance1 = new NotStaticClass(1);
            NotStaticClass instance2 = new NotStaticClass(2);

            instance1.Method();
            instance2.Method();

            NotStaticClass.field = 1;

            instance1.Method();
            instance2.Method();

            Console.ReadKey();
        }
    }
}
