using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Book
{
    class Title
    {
        string title;

        public Title(string title)
        {
            this.title = title;
        }
        void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: {0}", title);
        }
    }
}
