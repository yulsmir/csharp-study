using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1 or 2: ");

            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    { 
                        Console.WriteLine("One");
                        break;
                    }
                case "2":
                    { 
                        Console.WriteLine("Two");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Your number is not equal to 1 or 2.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
