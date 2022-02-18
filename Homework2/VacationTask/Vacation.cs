using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationTask
{
    class Vacation
    {
        public DateTime FirstDayOfVacation { get; set; }
        public DateTime LastDayOfVacation { get; set; }
        public Employee Employee { get; set; }
        public static List<Vacation> VacationList = new List<Vacation>();

        public Vacation()
        {
            //Used for initial vacation creation
        }

        public Vacation(Employee employee, DateTime firstDay, DateTime lastDay)
        {
            Employee = employee;
            FirstDayOfVacation = firstDay;
            LastDayOfVacation = lastDay;
        }

        public void GoOnVacation(Employee employee, DateTime firstDay, DateTime lastDay)
        {
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

        public double AverageVacationDays()
        {
           double sum = 0;
           double counter = 0;
           var days = from items in VacationList 
                      select new
                       {
                           days = items.LastDayOfVacation - items.FirstDayOfVacation
                       };

            foreach (var day in days)
            {
                sum = sum + day.days.TotalDays;
                counter++;
            }

            return sum/counter;
        }

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
    }
}
