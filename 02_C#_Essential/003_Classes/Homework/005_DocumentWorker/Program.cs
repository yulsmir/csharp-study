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

            DocumentWorker doc = null;

            if (accessKey == "prof")
            {
                doc = new ProDocumentWorker();
            }

            else if (accessKey == "expert")
            {
                doc = new ExpertDocumentWorker();
            }

            else
            {
                Console.WriteLine("Wrong access key");
                doc = new DocumentWorker();
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
