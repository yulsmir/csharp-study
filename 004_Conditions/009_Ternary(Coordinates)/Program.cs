using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Ternary_Coordinates_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -6, y = -5;

            string quadrant = (x > 0) ? ((y > 0) ? "I quadrant" : "IV quadrant") : ((y > 0) ? "II quadrant" : "III quadrant");

            //or

            quadrant = x > 0 ? (y > 0 ? "I quadrant" : "IV quadrant") : (y > 0 ? "II quadrant" : "III quadrant");

            //or
            quadrant = x > 0 ? y > 0 ? "I quadrant" : "IV quadrant" : y > 0 ? "II quadrant" : "III quadrant";

            Console.WriteLine(quadrant);
            Console.ReadKey();
        }
    }
}
