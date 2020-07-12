using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number1 = 0;
            Console.WriteLine(number1++); // Постфиксный инкремент - сначала выводим на экран, потом увелиичваем на 1
            Console.WriteLine(number1);
            Console.WriteLine("---------");

            byte number2 = 0;
            Console.WriteLine(++number2);
            Console.WriteLine("---------");

            sbyte number3 = 0;
            Console.WriteLine(number3--);
            Console.WriteLine(number3);
            Console.WriteLine("---------");

            sbyte number4 = 0;
            Console.WriteLine(--number4);

            Console.ReadKey();
        }
    }
}
