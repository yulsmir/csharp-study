using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_CoffeeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! We have the best coffee!");
            Console.WriteLine("Coffee cup sizes: 1 = small, 2 = medium, 3 = large");
            Console.WriteLine("Please, select your cup size: ");

            string coffeeSize = Console.ReadLine();

            int cost = 0;

            switch (coffeeSize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 50;
                    goto case "1";
                case "3":
                    cost += 75;
                    goto case "1";

                default:
                    Console.WriteLine("Incorrect choice. Please, choose 1, 2 or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Enter {0} cents", cost);
                Console.WriteLine("Thank you!");
            }

            else
            {
                Console.WriteLine("Please, repeat your choice.");
            }

            Console.ReadKey();
        }
    }
}
