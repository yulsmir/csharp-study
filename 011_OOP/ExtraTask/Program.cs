using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask
{
    class Program
    {
        class Address
        {
            /*public int index, house, apartment;
            public string country, city, street;*/

            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public int Index { get; set; }
            public int House { get; set; }
            public int Apartment { get; set; }
        }
        static void Main()
        {
            Address address1 = new Address()
            {
                Index = 12345,
                Country = "Ghana",
                City = "Zimba",
                Street = "Wallstreet",
                House = 23,
                Apartment = 1
            };

            Console.WriteLine("Index: {0}, Country: {1}, City: {2}, Street: {3}, House: {4}, Apartment: {5}", address1.Index, address1.Country, address1.City, address1.Street, address1.House, address1.Apartment);
            
            Console.ReadKey();
        }
    }
}
