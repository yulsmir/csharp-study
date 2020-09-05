using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask_01
{
    class Program
    {
        class Rectangle
        {
            public double side1;
            public double side2;

            // add oop
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double AreaCalculator(double side1, double side2)
            {
                return side1 * side2;
            }

            public double PerimeterCalculator(double side1, double side2)
            {
                return (side1 + side2) * 2;
            }

            public double Area { get; }
            public double Perimeter { get; }
        }
        static void Main()
        {
            
            Console.WriteLine("Enter the value of side 1 of the rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter the value of size 2 of the rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('-',30));

            Rectangle rectangle1 = new Rectangle(side1, side2);
            double Perimeter = rectangle1.PerimeterCalculator(side1, side2);
            double Area = rectangle1.AreaCalculator(side1, side2);
            Console.WriteLine("Perimeter: {0}, Area: {1}", Perimeter, Area);

            Console.ReadKey();
        }
    }
}
