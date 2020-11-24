using System;
using System.Collections.Generic;
using System.Text;

namespace HW_02
{
    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book book = new Book();
            book.FindIndex(str);
        }
    }
}
