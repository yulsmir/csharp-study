using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
    class BaseClass
    {
        public int baseNumber;

        public BaseClass()
        {
        }

        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
