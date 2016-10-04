using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
            // Backing field specific to salary employees:
        private decimal _weeklySalary;

            // Property:
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

            // Methods:
        public string NameAndSalary()
        {       // base is the parent - whose toString we overrode to be _firstName + _lastName
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }

        public override string ToString()
        {
            return base.ToString() + " " + this._weeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this._weeklySalary;
        }

        public override decimal GetYearlySalary()
        {
            return this._weeklySalary * 52;
        }

        // In constructor of child class, call constructor of parent class to do its work:
        public SalaryEmployee(string firstName, string lastName, DateTime startDate, decimal weeklySalary) 
            : base(firstName, lastName, startDate)
        {
            _weeklySalary = weeklySalary;
        }

        public SalaryEmployee() : base()
        {

        }

    }
}
