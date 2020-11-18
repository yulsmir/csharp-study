using System;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 23, 52, 5, 7, 45, 9 };

            array.ArraySortUp();

            foreach (int a in array)
                Console.WriteLine(a + " ");

            Console.ReadKey();
        }
    }
}
