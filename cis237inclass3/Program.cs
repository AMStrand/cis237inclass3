using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {

            SalaryEmployee sEmployee = new SalaryEmployee("Alyssa", "Strand", new DateTime(2013, 1, 1), 800.00m);

            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee.GetYearlySalary());

            HourlyEmployee hEmployee = new HourlyEmployee("Brandon", "Strand", new DateTime(2014, 6, 1), 17.4m, 40);

            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());

            IEmployeeCollection employeeCollection;
            employeeCollection = new EmployeeCollection();

            AddNewEmployees(employeeCollection);

            PrintEmployees(employeeCollection);
        }

        static void AddNewEmployees(IEmployeeCollection employeeCollection)
        {
            // Add a couple salary employees:
            employeeCollection.add("Peter", "Parker", new DateTime(2016, 1, 1), 650m);
            employeeCollection.add("Clark", "Kent", new DateTime(2015, 1, 1), 1200m);
            // Add a couple hourly employees:
            employeeCollection.add("Ben", "Parker", new DateTime(2013, 1, 1), 20.2m, 40);
            employeeCollection.add("Richard", "Nixon", new DateTime(2011, 1, 1), 30.5m, 38);

        }

        static void PrintEmployees(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine(employeeCollection.GetPrintString());
        }

    }
}
