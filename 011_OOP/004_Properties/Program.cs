using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _004_Properties
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;

        public double Pi
        {
            set { pi = value; }
        }
        public double E
        {
            get { return e; }
        }
    }

    class Program
    {
        static void Main()
        {
            Constants constants = new Constants();
            constants.Pi = 3.14159265D;
            Console.WriteLine("e = {0}", constants.E);

            Console.ReadKey();
        }
    }
}
