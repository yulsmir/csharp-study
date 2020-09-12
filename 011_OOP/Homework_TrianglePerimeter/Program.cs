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
            Point point3 = new Point(4, 2, "C");
            Point point4 = new Point(4, 0, "D");

            Figure figure1 = new Figure(point1, point2, point3, point4);

            Console.WriteLine("Figure name: {0}", figure1.Name);
            Console.WriteLine("Figure lengthside AB: {0}", figure1.LengthSide(point1, point2));
            Console.WriteLine("Figure lengthside BC: {0}", figure1.LengthSide(point2, point3));
            Console.WriteLine("Figure lengthside CD: {0}", figure1.LengthSide(point3, point4));
            Console.WriteLine("Figure lengthside DA: {0}", figure1.LengthSide(point4, point1));
            // Console.WriteLine(figure1.LengthSide(point1, point2));
            figure1.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
