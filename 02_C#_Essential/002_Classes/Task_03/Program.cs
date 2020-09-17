using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main()
        {
            Employee employee01 = new Employee("Max", "Ivanov", "manager", 4.5);
            employee01.printEmployeeInfo();

            Employee employee02 = new Employee("John", "Johnsson", "developer", 10);
            employee02.printEmployeeInfo();

            Employee employee03 = new Employee("Gosha", "Pupkin", "manager", 2);
            employee03.printEmployeeInfo();
            
            Employee employee04 = new Employee("Olga", "Olga", "office manager", 2);
            employee04.printEmployeeInfo();

            Console.ReadKey();
        }
    }
}
