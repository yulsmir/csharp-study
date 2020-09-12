using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();
            instance.MethodFromPArt1();
            instance.MethodFromPArt2();

            Console.ReadKey();
        }
    }
}
