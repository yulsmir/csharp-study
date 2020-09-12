using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
    class MyClass
    {
        private string field = null;
        public void SetField(string value)
        {
            field = value;
        }

        public string GetField()
        {
            return field;
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.SetField("Jonny");
            string @string = instance.GetField();
            Console.WriteLine(@string);

            Console.ReadKey();
        }
    }
}
