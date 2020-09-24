using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedFiled;
        public DerivedClass(int number1, int number2)
        {
            baseNumber = number1;
            derivedFiled = number2;
        }
    }
}
