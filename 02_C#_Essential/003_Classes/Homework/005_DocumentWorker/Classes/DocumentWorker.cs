using System;
using System.Collections.Generic;
using System.Text;

namespace _005_DocumentWorker
{
    class DocumentWorker
    {
        public string accessKey = null;

        public DocumentWorker()
        {

        }
        public void OpenDocument()
        {
            Console.WriteLine("Document is open.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in Pro Version.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving is available in Pro Version.");
        }
    }
}
