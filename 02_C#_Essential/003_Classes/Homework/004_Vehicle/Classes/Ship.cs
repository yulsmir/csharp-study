using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Vehicle.Classes
{
    class Ship : Vehicle
    {
        public int numOfPassengers;
        public string portAdress;

        public Ship(string name, double gpsLatitude, double gpsLongtitude, int numOfPassengers, string portAdress, double price, double speed, int releaseYear)
        {
            this.name = name;
            this.gpsLatitude = gpsLatitude;
            this.gpsLongtitude = gpsLongtitude;
            this.portAdress = portAdress;
            this.numOfPassengers = numOfPassengers;
            this.price = price;
            this.speed = speed;
            this.releaseYear = releaseYear;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Vehicle type: {0}", name);
            Console.WriteLine("GPS Location: latitude: {0}, longitude: {1}", gpsLatitude, gpsLongtitude);
            Console.WriteLine("Number of passengers {0}:", numOfPassengers);
            Console.WriteLine("Port address: {0}", portAdress);
            Console.WriteLine("Price: {0}", price);
            Console.WriteLine("Speed: {0}knot/h", speed);
            Console.WriteLine("Year of manufacturing: {0}", releaseYear);
            Console.WriteLine(new string('-', 30));
        }
    }
}
