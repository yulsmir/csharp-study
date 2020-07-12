using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_VolumeCount
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius = 2.4;
            double height = 1.3;
            double resultVolume = pi * (Math.Pow(radius, 2) * height);
            double resultSquare = (2 * pi * radius * height) + 2 * pi * (Math.Pow(radius, 2));
            Console.WriteLine(resultVolume);
            Console.WriteLine(resultSquare);

            Console.ReadKey();
        }
    }
}
