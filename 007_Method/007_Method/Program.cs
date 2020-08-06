using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Method
{
    class Program
    {
        static string Function(string name)
        {
            if (name == "fool")
            {
                return "You used inappropriate word";
            }
            string sentence = "Hello " + name + "!";
            return sentence;
        }
        static void Main()
        {
            string sentence = Function("fool");
            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
