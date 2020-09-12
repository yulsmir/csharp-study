using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_TrianglePerimeter
{
    class Figure
    {
        Point[] points;
        string name;

        public string Name { get { return name; } } 
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;

            name = "Triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;

            name = "Quadrangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;

            name = "Pentagon";
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (i == points.Length - 1)
                {
                    perimeter += LengthSide(points[0], points[points.Length - 1]);
                }
                else
                {
                    perimeter += LengthSide(points[i], points[i + 1]);
                }
            }
            Console.WriteLine("Perimeter is: {0}", perimeter);
        }
    }
}
