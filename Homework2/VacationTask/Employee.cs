using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationTask
{
    class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<Vacation> EmployeeVacation = new List<Vacation>();

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
