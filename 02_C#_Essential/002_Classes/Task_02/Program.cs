using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(75.30, 80.10, 0.13);

            converter.ConvertToUsd(130);
            converter.ConvertToEur(800);
            converter.ConvertFromEur(400);
            converter.ConvertFromUsd(1000);

            Console.ReadKey();
        }
    }
}
