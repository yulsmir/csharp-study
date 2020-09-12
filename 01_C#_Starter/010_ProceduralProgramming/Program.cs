using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    /* 
       Программа: Hello, world
       Эта программа, выводит в консоли “hello, world”
    */
    class Program // Любое имя подойдет для этого класса, а не только Program
    {
        static void Main(string[] args) // Этот метод должен называться "Main" (Обязательно!)
        {
            Console.Write("Hello world!");
            Console.ReadKey();
        }
    }
}
