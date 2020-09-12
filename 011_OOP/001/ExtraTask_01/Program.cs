using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of side 1 of the rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of size 2 of the rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(side1, side2);
            Console.WriteLine("Perimeter: {0}, Area: {1}", rectangle1.Perimeter, rectangle1.Area);

            Console.ReadKey();
        }
    }
}