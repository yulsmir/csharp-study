using System;
namespace Less03_task03
{
    class Program
    {
        static void Main(string[] args)
        {
            if (new MyClass() is Object)
            {
                Console.WriteLine("I'm object!");
            }
            else { Console.WriteLine("I’m not object!"); }
            Console.ReadKey();
        }
    }
    class MyClass { }
}