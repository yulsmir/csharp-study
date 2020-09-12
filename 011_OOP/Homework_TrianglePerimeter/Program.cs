using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_TrianglePerimeter
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 0, "A");
            Point point2 = new Point(1, 2, "B");
            Point point3 = new Point(3, 2, "C");
            Point point4 = new Point(3, 0, "D");
            Point point5 = new Point(3, 3, "E");

            Figure figure1 = new Figure(point1, point2, point3, point4, point5);

            Console.WriteLine("Figure name: {0}", figure1.Name);

            figure1.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
