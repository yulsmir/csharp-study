using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Book
{
    class Author
    {
        readonly string name;
        public Author(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Author name: {0}", name);
        }
    }
}
