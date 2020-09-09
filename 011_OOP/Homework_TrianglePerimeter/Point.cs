using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_TrianglePerimeter
{
    class Point
    {
        int a;
        int b;
        string name;

        public int A { get; }
        public int B { get; }
        public string Name { get; }

        public Point(int a, int b, string name)
        {
            this.a = a;
            this.b = b;
            this.name = name;
        }
    }
}
