using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Admin";
            string password = "P@ssw0rd";

            Console.Write("Enter login: ");

            string usersLogin = Console.ReadLine();
            if (login == usersLogin)
            {
                Console.Write("Enter Password: ");
                string usersPassword = Console.ReadLine();

                if (password == usersPassword)
                {
                    Console.WriteLine("Hello {0}, you are in the system.", usersLogin);
                }
                else
                {
                    Console.WriteLine("You entered wrong password.");
                }

            }
            Console.ReadKey();

        }
    }
}
