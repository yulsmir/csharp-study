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

            book01.Show();

            Console.ReadKey();
        }
    }
}
