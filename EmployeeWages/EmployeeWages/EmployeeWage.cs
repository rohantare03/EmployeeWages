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
        public int WagesPerHr = 20;
        public void DailyWage()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
                int DailyWagePerHr = EmpHr * WagesPerHr;
                Console.WriteLine("Dailywages :" + DailyWagePerHr);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
