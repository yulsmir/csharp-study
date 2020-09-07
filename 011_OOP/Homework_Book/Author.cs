using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Book
{
    class Author
    {
        string author;

        public Author(string author)
        {
            this.author = author;
        }
        void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Author: {0}", author);
        }
    }
}
