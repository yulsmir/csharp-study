using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Method
{
    class Program
    {
        static string Compare(int value1, int value2)
        {
            if (value1 < value2)
            {
                return "Comparison Less Then";
            }
            else if (value1 > value2)
            {
                return "Comparison Greater Then";
            }
            return "Comparison Equal";

        }
        static void Main(string[] args)
        {
            int operand1 = 1, operand2 = 2;
            string result = Compare(operand1, operand2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
