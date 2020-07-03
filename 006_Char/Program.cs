using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = '\x0041';
            char c = '\u0041';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
