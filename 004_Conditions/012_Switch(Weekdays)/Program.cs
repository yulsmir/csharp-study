using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Switch_Weekdays_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the weekday number: 1-2-3-4-5-6-7: ");
            string myDay = Console.ReadLine();

            int day = Convert.ToInt32(myDay);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Your weekday doesn't exist");
                    break;
            }
            Console.ReadKey();
        }
    }
}
