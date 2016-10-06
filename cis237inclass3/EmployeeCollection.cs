using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class EmployeeCollection : IEmployeeCollection
    {
            // It is possible to instantiate this array as a Employee type because it is an array.
        IEmployee[] employees = new Employee[10];

        int currentIndex;

            // Constructor 
        public EmployeeCollection()
        {
            currentIndex = 0;
        }

        public void add(string firstName, string lastName, DateTime startDate, decimal salary)
        {
            employees[currentIndex++] = new SalaryEmployee(firstName, lastName, startDate, salary);
        }

        public void add(string firstName, string lastName, DateTime startDate, decimal hourlyRate, decimal hoursPerWeek)
        {
            employees[currentIndex++] = new HourlyEmployee(firstName, lastName, startDate, hourlyRate, hoursPerWeek);
        }

        public string GetPrintString()
        {
            string allOutput = "";

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                        // How to use a method that is from one of the sub-classes:
                    if (employee.GetType() == typeof(SalaryEmployee))                                   // DOWN CASTING TYPE CHECK
                    {
                        allOutput += ((SalaryEmployee)employee).NameAndSalary() + Environment.NewLine;  // DOWN CASTING CODE
                    }
                    else
                    {
                        allOutput += employee.ToString() + Environment.NewLine;
                    }
                }
            }

            return allOutput;
        }
    }
}
