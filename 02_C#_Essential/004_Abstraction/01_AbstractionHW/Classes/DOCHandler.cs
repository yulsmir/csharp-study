using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractionHW.Classes
{
    class DOCHandler : AbstractHandler
    {
        string type = "DOC";
        public override void Open()
        {
            Console.WriteLine("{0} file is opened.", type);
        }
        public override void Create()
        {
            Console.WriteLine("{0} file is created.", type);
        }
        public override void Change()
        {
            Console.WriteLine("{0} file is changed.", type);
        }
        public override void Save()
        {
            Console.WriteLine("{0} file is saved.", type);
        }
    }
}
