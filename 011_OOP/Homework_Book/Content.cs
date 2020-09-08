using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Book
{
    class Content
    {
        string content;

        public Content(string content)
        {
            this.content = content;
        }
        void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Author: {0}", content);
        }
    }
}
