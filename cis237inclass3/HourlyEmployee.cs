using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
            // Backing fields:
        private decimal _hourlySalary;
        private decimal _hoursPerWeek;

            // Properties:
            // Properties don't have to be a direct relationship to a single variable.
        public decimal WeeklySalary
        {
            get { return this._hourlySalary * this._hoursPerWeek; }
        }

            // Constructors:
        public HourlyEmployee(string firstName, string lastName, DateTime startDate, decimal hourlyRate, decimal hoursPerWeek)
            : base(firstName, lastName, startDate)
        {
            this._hourlySalary = hourlyRate;
            this._hoursPerWeek = hoursPerWeek;
        }

        public HourlyEmployee() : base()
        {

        }

            // Methods:
        public override string ToString()
        {
            return base.ToString() + " " + this.WeeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.WeeklySalary;
        }

        public override decimal GetYearlySalary()
        {
            return this.WeeklySalary * 52;
        }
    }
}
