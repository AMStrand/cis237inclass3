using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
        // Abstract - used as a base class for other classes but is not directly instantiated - not enough info by itself
    abstract class Employee : IEmployee
    {
            // Declare Employee backing fields:
        protected string _firstName;
        protected string _lastName;
        protected DateTime _startDate;

            // Property fields and getters/setters for the backing fields:
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        // Methods:

            // Override toString method:
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

            // Method to determine the length of employment in years using the start date:
        public int GetEmploymentDurationInYears()
        {
            return new TimeSpan(DateTime.Now.Ticks - this._startDate.Ticks).Days / 365;
        }

            // Method to get all employee information - name and length of employment:
        public virtual string GetAllEmployeeInformation()
        {
            return this._firstName + " " + this._lastName + " " + this.GetEmploymentDurationInYears();
        }

            // Get the Yearly Salary of the employee:
            // Abstract because we want the sub classes to implement it, but it can't be used at this level, so no method body:
            // Every sub class that calls from Employee MUST contain an override method for each abstract parent method:
        public abstract decimal GetYearlySalary();

        // Constructors:

        public Employee(string firstName, string lastName, DateTime startDate)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._startDate = startDate;
        }

        public Employee()
        {

        }

    }
}
