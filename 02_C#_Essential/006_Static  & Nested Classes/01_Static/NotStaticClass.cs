using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Static
{
    class NotStaticClass
    {
        private int Id;
        public static int field;

        public NotStaticClass(int Id)
        {
            this.Id = Id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field = {1}", Id, field);
        }
    }
}
