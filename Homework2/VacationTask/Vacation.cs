using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationTask
{
    class Vacation
    {
        public DateTime FirstDayOfVacation { get; private set; }
        public DateTime LastDayOfVacation { get; private set; }
        public Employee Employee { get; private set; }
        private static List<Vacation> VacationList = new List<Vacation>();

        //Empty ctor for initial object creation
        public Vacation()
        {
            //No Implementation
        }

        //Ctor with parameters do add people on vacation to the list
        public Vacation(Employee employee, DateTime firstDay, DateTime lastDay)
        {
            Employee = employee;
            FirstDayOfVacation = firstDay;
            LastDayOfVacation = lastDay;
        }

        //Method to send person on vacation. adds vacation to the main list and to the personal employee list
        public void GoOnVacation(Employee employee, DateTime firstDay, DateTime lastDay)
        {

            if(TakenVacationCheck(employee,firstDay,lastDay))
            {
                throw new ArgumentException("Vacation already taken");
            }

            if(firstDay>lastDay)
            {
                throw new ArgumentException("First vacation day, cannot be later than the last vacation day");
            }

            if(firstDay.Year!=2021)
            {
                throw new ArgumentException("You can go on vacation only in 2021");
            }

            VacationList.Add((new Vacation(employee, firstDay, lastDay)));
            employee.EmployeeVacation.Add(new Vacation(employee, firstDay, lastDay));
        }

        //Method to find the average length of vacation in the organization.
        public double AverageVacationDays()
        {
           double sum = 0;
           double counter = 0;

           var days = VacationList.Select(d => d.LastDayOfVacation - d.FirstDayOfVacation);

            foreach (var day in days)
            {
                sum += day.Days;
                counter++;
            }
            return sum/counter;
        }

        //Method to find the average length of vacation for each employee
        public void AverageEmployeeVacationDays()
        {
            var AverageEmployeeVacationDays =
                from item in VacationList
                group item by item.Employee.FirstName into NameGroup
                select new
                {
                    Name = NameGroup.Key,
                    AverageDays = NameGroup.Average(x => (x.LastDayOfVacation - x.FirstDayOfVacation).TotalDays)
                };

            foreach (var n in AverageEmployeeVacationDays)
            {
                Console.WriteLine(Tuple.Create(n.Name, n.AverageDays));
            }

        }

        //Method to print a set of tuples "number of the month of the year - the number of employees on vacation
        public void EmployeesOnVacationByMonth()
        {

            var vacationsByMonth =
                from month in Enumerable.Range(1, 12)
                let key = new { Month = month }
                join revision in VacationList on key
                          equals new
                          {
                              revision.FirstDayOfVacation.Month
                          } into g
                select new { GroupCriteria = key, Count = g.Count() }; 

            foreach (var n in vacationsByMonth)
            {
                Console.WriteLine(Tuple.Create(n.GroupCriteria, n.Count));
            }
        }

        //Indicate dates in 2021 on which employees did not take vacations
        public void MonthsWithNoVacation()
        {
            var vacationsByMonth =
                from month in Enumerable.Range(1, 12)
                let key = new { Month = month }
                join revision in VacationList on key
                          equals new
                          {
                              revision.FirstDayOfVacation.Month
                          } into g
                select new { GroupCriteria = key, Count = g.Count() };

            foreach (var n in vacationsByMonth)
            {
                if(n.Count == 0)
                {
                    Console.WriteLine(Tuple.Create(n.GroupCriteria, n.Count));
                }
            }
        }

        //checking if dates are not already taken by the employee
        public bool TakenVacationCheck(Employee employee, DateTime firstDay, DateTime lastDay)
        {
            var test = VacationList.Where(d => d.Employee == employee && d.FirstDayOfVacation < firstDay && d.LastDayOfVacation > lastDay).Any();

            if (test)
                return true;
            return false;
        }


    }
}
