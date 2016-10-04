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

        }
    }
}
