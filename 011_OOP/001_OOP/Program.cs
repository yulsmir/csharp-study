using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_OOP
{
    class Buterfly
    {
        public string name;

        public void Fly()
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Fly!");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Buterfly mahaon = new Buterfly();
            mahaon.name = "Admiral";
        }
    }
}
