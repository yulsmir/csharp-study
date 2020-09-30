using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Vehicle.Classes
{
    class Car : Vehicle
    {
        public string name = "Car";

        public override void PrintInfo()
        {
            base.PrintInfo();
        }

        public Car(string name, double gpsLatitude, double gpsLongtitude, double price, double speed, int releaseYear)
        {
            this.name = name;
            this.gpsLatitude = gpsLatitude;
            this.gpsLongtitude = gpsLongtitude;
            this.price = price;
            this.speed = speed;
            this.releaseYear = releaseYear;
        }

    }
}
