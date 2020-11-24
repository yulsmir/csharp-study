using System;

namespace _04_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass.Property = 23;
            Console.WriteLine(NotStaticClass.Property);

            Console.ReadKey();
        }
    }
}
