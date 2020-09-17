using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Employee
    {
        string firstname, lastname, jobtitle;
        double yearsOfExperience;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        public double YearsOfExperience { get; set; }

        public Employee(string firstname, string lastname, string jobtitle, double yearsOfExperience)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.jobtitle = jobtitle;
            this.yearsOfExperience = yearsOfExperience;
        }

        public double getSalary()
        {
            double hours = 160D;
            double hourlyRate = 10D;
            double salary = (hourlyRate * hours) + (yearsOfExperience * 100);

            switch (jobtitle)
            {
                case "manager": hourlyRate = 8.0D;
                    break;
                case "developer": hourlyRate = 10.0D;
                    break;
                case "cleaner": hourlyRate = 5.0D;
                    break;

                default: hourlyRate = 4.0D;
                    break;
            }
            return salary;
        }

        public double getTaxes()
        {
            double salary = getSalary();
            double taxes = salary * 0.3;
            return taxes;
        }

        public void printEmployeeInfo()
        {
            Console.WriteLine("First name: {0}", firstname);
            Console.WriteLine("Last name: {0}", lastname);
            Console.WriteLine("Job title: {0}", jobtitle);
            Console.WriteLine("Salary: {0} USD", getSalary());
            Console.WriteLine("Taxes: : {0} USD", getTaxes());
            Console.WriteLine(new string('-', 30));
        }
    }
}
