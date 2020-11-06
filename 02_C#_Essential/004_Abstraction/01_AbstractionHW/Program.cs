using _01_AbstractionHW.Classes;
using System;

namespace _01_AbstractionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCHandler docFile = new DOCHandler();
            docFile.Create();
            docFile.Change();
            docFile.Open();
            docFile.Save();
            Console.WriteLine(new string('-', 20));

            TXTHandler txtFile = new TXTHandler();
            txtFile.Create();
            txtFile.Change();
            txtFile.Open();
            txtFile.Save();
            Console.WriteLine(new string('-', 20));

            XMLHandler xmlFile = new XMLHandler();
            xmlFile.Create();
            xmlFile.Change();
            xmlFile.Open();
            xmlFile.Save();
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}
