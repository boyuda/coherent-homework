using System;
using System.Collections.Generic;

namespace VacationTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeOne = new Employee("Dmitrijus", "Byckovas");
            var employeeTwo = new Employee("Egle", "Egliene");
            var date = new DateTime(2021, 12, 25);


            //var vacation = new Vacation(employeeOne, new DateTime(2021, 01, 15), new DateTime(2021, 01, 16));


            var vacation = new Vacation();


            vacation.GoOnVacation(employeeOne, new DateTime(2021, 01, 20), new DateTime(2021, 01, 25));
            vacation.GoOnVacation(employeeOne, new DateTime(2021, 01, 15), new DateTime(2021, 01, 16));
            vacation.GoOnVacation(employeeOne, new DateTime(2021, 01, 25), new DateTime(2021, 01, 30));
            vacation.GoOnVacation(employeeOne, new DateTime(2021, 01, 01), new DateTime(2021, 01, 10));
            vacation.GoOnVacation(employeeTwo, new DateTime(2021, 02, 15), new DateTime(2021, 02, 18));
            vacation.AverageVacationDays();
            vacation.AverageEmployeeVacationDays();



        }
    }
}
