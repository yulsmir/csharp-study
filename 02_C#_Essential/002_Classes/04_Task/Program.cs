using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Task
{
    class Program
    {
        static void Main()
        {
            Invoice invoice01 = new Invoice(12345, "John", "Rozetka");
            invoice01.printInvoiceInfo();
            Console.ReadKey();
        }
    }
}
