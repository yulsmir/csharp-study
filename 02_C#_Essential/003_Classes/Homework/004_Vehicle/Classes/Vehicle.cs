using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Vehicle.Classes
{
    class Vehicle
    {
        //coordinates in decimal degrees
        protected string name;
        public double gpsLatitude;
        public double gpsLongtitude;

        public double price;
        public double speed;

        public int releaseYear;

        public Vehicle()
        {

        }
        public Vehicle(string name, double gpsLatitude, double gpsLongtitude, double price, double speed, int releaseYear)
        {
            this.name = name;
            this.gpsLatitude = gpsLatitude;
            this.gpsLongtitude = gpsLongtitude;
            this.price = price;
            this.speed = speed;
            this.releaseYear = releaseYear;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Vehicle name: {0}", name);
            Console.WriteLine("GPS Location: latitude: {0}, longitude: {1}", gpsLatitude, gpsLongtitude);
            Console.WriteLine("Price: ${0}", price);
            Console.WriteLine("Speed: {0} km/h", speed);
            Console.WriteLine("Year of manufacturing: {0}", releaseYear);
            Console.WriteLine(new string('-', 30));
        }
    }
}
