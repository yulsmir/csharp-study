using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Static
{
    class NotStaticClass
    {
        static int field;
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}
