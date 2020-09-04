using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Constructor
{
    class Program
    {
        static void Main()
        {
            Point pointA = new Point();
            Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);
            Console.WriteLine(new string('-', 30));

            Point pointB = new Point();
            Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);

            Console.ReadKey();
        }
    }
}
