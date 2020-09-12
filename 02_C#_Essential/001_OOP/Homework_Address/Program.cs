using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Address
{
    class Program
    {
        static void Main()
        {
            Address address01 = new Address();

            Console.WriteLine("Enter the Index: ");
            address01.Index = Console.ReadLine();
            Console.WriteLine("Enter the Country: ");
            address01.Country = Console.ReadLine();
            Console.WriteLine("Enter the City: ");
            address01.City = Console.ReadLine();
            Console.WriteLine("Enter the Street: ");
            address01.Street = Console.ReadLine();
            Console.WriteLine("Enter the House: ");
            address01.House = Console.ReadLine();
            Console.WriteLine("Enter the Apartment: ");
            address01.Apartment = Console.ReadLine();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Index: {0}", address01.Index);
            Console.WriteLine("Country: {0}", address01.Country);
            Console.WriteLine("City: {0}", address01.City);
            Console.WriteLine("Street: {0}", address01.Street);
            Console.WriteLine("House: {0}", address01.House);
            Console.WriteLine("Apartment: {0}", address01.Apartment);
            Console.ReadKey();
        }
    }
}
