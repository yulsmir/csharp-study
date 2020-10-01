using System;
using System.Collections.Generic;
using System.Text;

namespace _005_DocumentWorker.Classes
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in new format");
        }
    }
}
