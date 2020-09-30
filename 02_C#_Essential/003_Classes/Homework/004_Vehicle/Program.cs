using System;
using _004_Vehicle.Classes;

namespace _004_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Chevrolet", 20.354567, 45.45656768, 25.000, 66, 1992);
            Ship ship1 = new Ship("Kruzenshtern", 33.455676, 78.3445522, 156, "Chicago, IL", 44500, 140, 2010);
            Plane plane1 = new Plane("TU 134", 45.1234556, 34.4545646, 8500, 60, 1345600, 200, 2018);

            car1.PrintInfo();
            ship1.PrintInfo();
            plane1.PrintInfo();

            Console.ReadKey();
        }
    }
}
