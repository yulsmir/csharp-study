using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Привет ";
            string word2 = "Мир!";
            string phrase = word1 + word2;
            Console.WriteLine(phrase);
            Console.WriteLine("Hello " + "World!");

            Console.ReadKey();
        }
    }
}
