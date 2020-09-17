using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Task
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        readonly double price;

        string article;
        int quantity;

        public string Article { get { return article; } }
        public int Quantity { get { return quantity; } }


        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public double CalculatePriceNoTAX()
        {
            double totalPrice = price * quantity;
            return totalPrice;
        }
        public double CalculatePriceWithTAX()
        {
            double tax = 0.30d;
            double totalPrice = (price * quantity) * tax;
            return totalPrice;
        }

        public void printInvoiceInfo()
        {
            Console.WriteLine("Account: {0}", account);
            Console.WriteLine("Customer: {0}", customer);
            Console.WriteLine("Provider: {0}", provider);
            Console.WriteLine("Article: {0}", article);
            Console.WriteLine("Quantity: {0}", quantity);
            Console.WriteLine("Price: {0} USD", price);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Total price (no tax included): {0} USD", CalculatePriceNoTAX());
            Console.WriteLine("Total price with including tax: {0} USD", CalculatePriceWithTAX());
        }

        // TO DO : finish constructor + invoice calculation
    }
}
