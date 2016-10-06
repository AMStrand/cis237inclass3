using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployeeCollection
    {

        void add(string firstName, string lastName, DateTime startDate, decimal salary);

        void add(string firstName, string lastName, DateTime startDate, decimal hourlyRate, decimal hoursPerWeek);

        string GetPrintString();
    }
}
