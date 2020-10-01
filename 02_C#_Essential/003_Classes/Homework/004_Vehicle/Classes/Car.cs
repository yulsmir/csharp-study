using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Vehicle.Classes
{
    class Car : Vehicle
    {
        public override void PrintInfo()
        {
            base.PrintInfo();
        }

        public Car(string name, double gpsLatitude, double gpsLongtitude, double price, double speed, int releaseYear)
                : base(name, gpsLatitude, gpsLongtitude, price, speed, releaseYear)
        {
            
        }

    }
}
