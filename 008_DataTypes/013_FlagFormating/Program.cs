using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_FlagFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C format: {0:C}", 99.9);         // денежный формат
            Console.WriteLine("F format: {0:##}", 99.935);      // фиксированная точность
            Console.WriteLine("N format: {0:N}", 99999);        // стандартное числовое форматирование
            Console.WriteLine("X format: {0:X}", 255);          // шестнадцатиричный формат
            Console.WriteLine("D format: {0:D}", 0xFF);         // десятичный формат
            Console.WriteLine("E format: {0:E}", 9999);         // экспоненциальный формат
            Console.WriteLine("G format: {0:G}", 99.9);         // общий формат
            Console.WriteLine("P format: {0:P}", 99.9);         // процентнай формат

            Console.ReadKey();
        }
    }
}
