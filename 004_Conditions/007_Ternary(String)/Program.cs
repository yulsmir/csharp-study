using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ternary_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetingString = "Hello ";
            Console.WriteLine("Enter Your Login:");

            string login = Console.ReadLine();

            greetingString += login == "Admin" ? "Administrator" : "User";
            Console.WriteLine(greetingString);
            
            Console.ReadKey();
        }
    }
}
