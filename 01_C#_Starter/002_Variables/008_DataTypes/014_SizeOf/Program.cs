using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_SizeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int doubleSize = sizeof(double);
            Console.WriteLine("Размер типа double: {0} байт.", doubleSize);

            Console.WriteLine("Размер типа int: {0} байт.", sizeof(int));
            Console.WriteLine("Размер типа bool: {0} байт.", sizeof(bool));
            Console.WriteLine("Размер типа long: {0} байт.", sizeof(long));
            Console.WriteLine("Размер типа short: {0} байт.", sizeof(short));

            Console.ReadKey();
        }
    }
}
