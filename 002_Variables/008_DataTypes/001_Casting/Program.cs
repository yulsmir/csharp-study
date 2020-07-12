using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            int b = 0;
            b = a;
            Console.WriteLine(b);

            int c = 255;
            float d = 0f;
            d = c;
            Console.WriteLine(d);

            int e = 256;
            byte f = 0;
            f = (byte)e;
            Console.WriteLine(f);

            float g = 10.5F;
            int h = 0;
            h = (int)g;
            Console.WriteLine(h);

            const int i = 255;
            byte j = 0;
            j = i;
            Console.WriteLine(j);

            const float k = 255;
            byte l = 0;
            l = (byte)k;

            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}
