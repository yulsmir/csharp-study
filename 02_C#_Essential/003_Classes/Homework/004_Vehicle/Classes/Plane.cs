using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Vehicle.Classes
{
    class Plane : Vehicle
    {
        public double gpsAltitude;
        public int numOfPassengers;

        public Plane(string name, double gpsLatitude, double gpsLongtitude, double gpsAltitude, int numOfPassengers,  double price, double speed, int releaseYear)
        {
            this.name = name;
            this.gpsLatitude = gpsLatitude;
            this.gpsLongtitude = gpsLongtitude;
            this.gpsAltitude = gpsAltitude;
            this.numOfPassengers = numOfPassengers;
            this.price = price;
            this.speed = speed;
            this.releaseYear = releaseYear;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Vehicle type: {0}", name);
            Console.WriteLine("GPS Location: latitude: {0}, longitude: {1}, altitude: {2}", gpsLatitude, gpsLongtitude, gpsAltitude);
            Console.WriteLine("Number of passengers {0}:", numOfPassengers);
            Console.WriteLine("Price: ${0}", price);
            Console.WriteLine("Speed: {0} miles/h", speed);
            Console.WriteLine("Year of manufacturing: {0}", releaseYear);
            Console.WriteLine(new string('-', 30));
        }
    }
}
