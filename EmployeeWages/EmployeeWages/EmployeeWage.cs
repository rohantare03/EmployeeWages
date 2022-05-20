using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWage
    {
        public int EmpHr = 0;
        public int WagesPerHr = 20;
        public const int IsFullTime = 2;
        public const int IsPartTime = 1;
        public void EmpWage()
        {
            Random check = new Random();
            int CheckEmp = check.Next(0, 3);
            switch (CheckEmp)
            {
                case IsPartTime:
                    EmpHr = 4;
                    break;
                case IsFullTime:
                    EmpHr = 8;
                    break;
                default:
                    EmpHr = 0;
                    break;
            }
            int empwage = EmpHr * WagesPerHr;
            Console.WriteLine("Dailywages :" + empwage);
        }
    }
}
