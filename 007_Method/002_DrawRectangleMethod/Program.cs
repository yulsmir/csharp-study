using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DrawRectangleMethod
{
    class Program
    {
        static void DrawRectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            DrawRectangle(10, 4);
            DrawRectangle(6, 14);
            Console.ReadKey();
        }
    }
}
