using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Ternary_cost_
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = 10;
            double price = 100;
            double discount = 0.75;
            double cost;

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;

            Console.WriteLine("Total cost: {0} usd", cost);
            Console.ReadKey();

        }
    }
}
