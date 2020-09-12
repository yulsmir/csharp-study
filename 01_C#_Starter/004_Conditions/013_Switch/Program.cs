using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the weekday number: 1-2-3-4-5-6-7: ");

            string day = Console.ReadLine();
            switch (day)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("This weekday is a working day.");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("This weekday is a weekend.");
                    break;

                default:
                    Console.WriteLine("The day you entered doesn't exist.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
