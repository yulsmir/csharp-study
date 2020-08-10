using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            Console.WriteLine("First part of method Recursion: {0}", counter);
            if (counter != 0)
            {
                Method(counter);
            }
        }
        static void Method(int counter)
        {
            Console.WriteLine("First part of method Recursion: {0}", counter);
            Recursion(counter);
            Console.WriteLine("Second part of method Recursion: {0}", counter);
        }

        static void Main()
        {
            Method(3);
            Console.ReadKey();
        }
    }
}
