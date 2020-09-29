using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Printer
{
    class Printer
    {
        string value;

        public string Value { get; set; }
        public Printer()
        {
            Value = value;
        }

        public virtual void Print(string Value)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(Value);
        }
    }
}
