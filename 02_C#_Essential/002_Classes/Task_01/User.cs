using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class User
    {
        string login, name, lastName;
        byte age;
        readonly DateTime registerDate = new DateTime();

        public string Login { set; get; }
        public string Name { set; get; }
        public string LastName { set; get; }
        public byte Age { set; get; }

        public User(string login, string name, string lastName, byte age)
        {
            this.login = login;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.registerDate = DateTime.Now;
        }
        public void ShowUserInfo()
        {
            Console.WriteLine("Login: {0}", login);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("LastName: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Date of registration: {0}", registerDate);
        }
    }
}
