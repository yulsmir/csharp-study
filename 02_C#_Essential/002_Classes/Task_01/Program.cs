using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Login", "John", "Johnson", 25);
            user1.ShowUserInfo();
            Console.ReadKey();
        }
    }
}
