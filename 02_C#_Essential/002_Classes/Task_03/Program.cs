using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void DrawLine()
        {
            Console.WriteLine(new string('-', 30));
        }
        static void Main()
        {
            Employee employee01 = new Employee("Max", "Ivanov", "manager", 4.5);
            employee01.printEmployeeInfo();
            DrawLine();

            Employee employee02 = new Employee("John", "Johnsson", "developer", 10);
            employee02.printEmployeeInfo();
            DrawLine();

            Console.ReadKey();
        }
    }
}
