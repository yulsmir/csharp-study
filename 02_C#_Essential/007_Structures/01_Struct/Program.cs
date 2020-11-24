using System;

namespace _01_Struct
{
    struct Notebook
    {
        private string model;
        private string manufacturer;
        private double price;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine(model);
            Console.WriteLine(manufacturer);
            Console.WriteLine(price);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Model = "SleekBook Pro";
            notebook.Manufacturer = "HP";
            notebook.Price = 3600.50;

            notebook.ShowInfo();

            Console.ReadKey();
        }
    }
}
