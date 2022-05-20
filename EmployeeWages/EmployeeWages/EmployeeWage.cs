using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWage
    {
        public const int WagesPerHr = 20;
        public const int FullTimeWorkHrsPerDay = 8;
        public const int PartTimeWorkHoursPerDay = 4;
        public const int IsFullTime = 2;
        public const int IsPartTime = 1;
        public const int IsAbsent = 0;
        public const int NumWorkDaysPerMonth = 20;
        public int EmpMontlyWage = 0;
        public int EmpDailyWage = 0;

        public void MonthWage()
        {
            int Day = 1;
            int EmpWorkHrs = 0;
            while (Day <= NumWorkDaysPerMonth)
            {
                Random check = new Random();
                int CheckEmp = check.Next(0, 3);
                switch (CheckEmp)
                {
                    case IsAbsent:
                        EmpWorkHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkHrs = 4;
                        break;
                    case IsFullTime:
                        EmpWorkHrs = 8;
                        break;
                }
                EmpDailyWage = EmpWorkHrs * WagesPerHr;

                EmpMontlyWage += EmpDailyWage;
                Day++;
            }
            Console.WriteLine("Employee Montly Wage :" + EmpMontlyWage);
        }
    }
}
