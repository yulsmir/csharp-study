using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_IsAS
{
    class ClassA { }
    class ClassB : ClassA { }
    class Program
    {        
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }

            // or

            a = b as ClassA;

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
