using System;

namespace HW_02
{
    class Book
    {
        public void FindIndex(string str)
        {
            Console.WriteLine("Find string: " + str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Word");

            Console.ReadKey();
        }
    }
}
