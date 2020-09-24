using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritence
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance1 = new DerivedClass();
            BaseClass instance2 = new BaseClass();

            BaseClass instance3 = new DerivedClass();

            Console.WriteLine(instance1.publicField);
            Console.WriteLine(instance2.publicField);

            Console.WriteLine(instance3.x);
            Console.ReadKey();
        }
    }
}
