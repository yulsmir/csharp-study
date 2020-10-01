using System;
using System.Collections.Generic;
using System.Text;

namespace _005_DocumentWorker.Classes
{
    class ProDocumentWorker : DocumentWorker
    {
        public new string accessKey = "12345";

        public override void EditDocument()
        {
            Console.WriteLine("Document was edited.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in old format. Other formats are available in Expert Version.");
        }
    }
}
