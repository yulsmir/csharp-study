using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Book
{
    class Program
    {
        static void Main()
        {
            Book book01 = new Book("Encyclopedia", "John Johnsson", "Text of description");
            Book book02 = new Book("Bice book", "Author Author", "Text of description");

            book01.Show();
            book02.Show();

            Console.ReadKey();
        }
    }
}
