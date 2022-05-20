using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWage
    {
        public int EmpWagePerHr = 20;
        public int FullTimeWorkHrsPerDay = 8;
        public int PartTimeWorkHrsPerDay = 4;
        public int MaxWorkHrs = 100;
        public int MaxWorkDays = 20;
        public string CompanyName;

        public EmployeeWage(string CompanyName, int EmpWagePerHr, int FullTimeWorkHrsPerDay, int PartTimeWorkHrsDay, int MaxWorkHrs, int MaxWorkDays)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHr = EmpWagePerHr;
            this.FullTimeWorkHrsPerDay = FullTimeWorkHrsPerDay;
            this.PartTimeWorkHrsPerDay = PartTimeWorkHrsDay;
            this.MaxWorkHrs = MaxWorkHrs;
            this.MaxWorkDays = MaxWorkDays;
        }
    }

    class CompanyWage_Computation
    {
        public const int IsFullTime = 2;
        public const int IsPartTime = 1;
        public const int IsAbsent = 0;
        public int EmpDailyWage = 0;
        public int TotalWage = 0;
        public Dictionary<string, EmployeeWage> Companies = new Dictionary<string, EmployeeWage>();

        public void Add_Company(string CompanyName, int EmpWagePerHr, int FullTimeWorkHrsPerDay, int PartTimeWorkHrsDay, int MaxWorkHrs, int MaxWorkDays)
        {
            EmployeeWage comp = new EmployeeWage(CompanyName.ToLower(), EmpWagePerHr, FullTimeWorkHrsPerDay, PartTimeWorkHrsDay, MaxWorkHrs, MaxWorkDays);
            Companies.Add(CompanyName.ToLower(), comp);
        }
        public int IsEmpPresent()
        {
            return new Random().Next(0, 3);
        }
        public void Calc_CompanyWage(string CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkHrs = 0;
            int TotalWorkHrs = 0;
            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company doesnt exists");
            Companies.TryGetValue(CompanyName.ToLower(), out EmployeeWage comp);

            while (DayNumber < comp.MaxWorkDays && TotalWorkHrs <= comp.MaxWorkHrs)
            {
                switch (IsEmpPresent())
                {
                    case IsAbsent:
                        EmpWorkHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkHrs = comp.PartTimeWorkHrsPerDay;
                        break;
                    case IsFullTime:
                        EmpWorkHrs = comp.FullTimeWorkHrsPerDay;
                        break;
                }
                EmpDailyWage = EmpWorkHrs * comp.EmpWagePerHr;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkHrs += EmpWorkHrs;
            }
            CompanyWage_Computation employeeWageComputation = new CompanyWage_Computation();
            employeeWageComputation.TotalWage = TotalWage;
            Console.WriteLine("The Name of the Company : " + CompanyName);
            Console.WriteLine("Total Working Days :" + DayNumber + "  " + "Total Working Hours :" + TotalWorkHrs + " " + "Total Employee Wage :" + TotalWage);

        }
    }
}
