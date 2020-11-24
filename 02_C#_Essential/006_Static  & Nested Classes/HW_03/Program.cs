using System;

namespace HW_03
{

    class Book
    {
        public class Notes
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;

                }
            }
        }

        public void Findnext(string str)
        {
            Console.WriteLine("find string: " + str);
        }

        static class FindAndReplacemanager
        {
            static public void FindNext(string str)
            {
                Book book = new Book();
                book.Findnext(str);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book.Notes note = new Book.Notes();

            note.Text = "Note 1";
            note.Text = "Note 2";

            Console.WriteLine(note.Text);

            Console.ReadKey();
        }
    }
}