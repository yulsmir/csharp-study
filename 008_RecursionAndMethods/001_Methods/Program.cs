using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Methods overload
namespace _001_Methods
{
    class Program
    {
        static int Difference(int height, int width)
        {
            return height - width;
        }
        static void Main()
        {
            int difference = Difference(6, 5);
            Console.WriteLine("Difference equals: {0}", difference);

            //or

            difference = Difference(width: 5, height: 6);
            Console.WriteLine("Difference equals: {0}", difference);
            Console.ReadKey();
        }
    }
}
