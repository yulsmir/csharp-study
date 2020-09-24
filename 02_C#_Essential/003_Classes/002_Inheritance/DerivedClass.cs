using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inheritance
{
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClaspus.protectedField";
        }
    }
}