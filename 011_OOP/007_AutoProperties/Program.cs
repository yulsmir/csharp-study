using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_AutoProperties
{
    class Program
    {
        public class Author
        {
            public string Name { get; set; }
            public string Book { get; set; }
        }

        static void Main()
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter",
                Book = "CLR via C#"
            };

            Author author2 = new Author()
            {
                Name = "Steve McConnel",
                Book = "Code Complete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            Console.ReadKey();
        }
    }
}
