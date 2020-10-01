using System;
using _005_DocumentWorker.Classes;

namespace _005_DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the access key: ");
            string accessKey = Console.ReadLine();

            if (accessKey == null)
            {
                DocumentWorker worker1 = new DocumentWorker();
            }

            else if (accessKey == "12345")
            {
                ProDocumentWorker worker2 = new ProDocumentWorker();
            }

            else if (accessKey == "987654")
            {
                ExpertDocumentWorker worker3 = new ExpertDocumentWorker();
            }

            Console.ReadKey();
        }
    }
}
