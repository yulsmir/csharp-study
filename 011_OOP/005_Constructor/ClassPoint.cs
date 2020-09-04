using System;

namespace Classes
{
    class Point
    {
        private int x, y;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public Point()
        {
            Console.WriteLine("Default constructor");
        }

        public Point(int x, int y)
        {
            Console.WriteLine("User constructor");
            this.x = x;
            this.y = y;
        }
    }
}