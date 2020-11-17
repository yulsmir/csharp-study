using System;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Divide(23, 31));
            Console.WriteLine(Calculator.Multiply(0, 167));
            Console.WriteLine(Calculator.Sum(-35, 1234));
            Console.WriteLine(Calculator.Subtract(3456.45, 1234.37));
        }
    }
}
