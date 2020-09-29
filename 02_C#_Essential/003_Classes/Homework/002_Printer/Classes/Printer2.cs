using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Printer
{
    class Printer2 : Printer
    {
        public override void Print(string Value)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Value);
        }
    }
}
