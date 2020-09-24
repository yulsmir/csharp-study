using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inheritance
{
    class BaseClass
    {
        public string publicField = "BaseClass.publicFiled";
        private string privateField = "BaseClass.privateFiled";
        protected string protectedField = "BaseClass.protectedField";

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
