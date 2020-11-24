using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Static
{
    class NotStaticClass
    {
        private int id;

        public NotStaticClass(int id)
        {
            this.id = id;
        }

        public static void Method()
        {
            Console.WriteLine("Static methods can't use nonstatic fields.");
        }

    }
}
