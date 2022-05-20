using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWage
    {
        public int EmpPresent = 1;
        public int EmpHr = 8;
        public int PartTimeEmpHr = 4;
        public int WagesPerHr = 20;
        public int FullTimeEmp = 1;
        public void PartTimeWage()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");

                Random Timecheck = new Random();
                int CheckTimeEmp = Timecheck.Next(0, 2);
                if (FullTimeEmp == CheckTimeEmp)
                {
                    int DailyWagePerHr = EmpHr * WagesPerHr;
                    Console.WriteLine("Dailywages :" + DailyWagePerHr);
                }
                else
                {
                    int DailyWagePerHr1 = PartTimeEmpHr * WagesPerHr;
                    Console.WriteLine("Dailywages :" + DailyWagePerHr1);
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
