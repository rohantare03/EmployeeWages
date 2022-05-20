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

    class EmpWageComputation
    {
        public const int IsFullTime = 2;
        public const int IsPartTime = 1;
        public const int IsAbsent = 0;
        public int EmpDailyWage = 0;
        public int TotalWage = 0;
        public Dictionary<string, EmployeeWage> Companies = new Dictionary<string, EmployeeWage>();

        public void AddCompany(string CompanyName, int EmpWagePerHr, int FullTimeWorkHrsPerDay, int PartTimeWorkHrsDay, int MaxWorkHrs, int MaxWorkDays)
        {
            EmployeeWage company = new EmployeeWage(CompanyName.ToLower(), EmpWagePerHr, FullTimeWorkHrsPerDay, PartTimeWorkHrsDay, MaxWorkHrs, MaxWorkDays);
            Companies.Add(CompanyName.ToLower(), company);
        }
        public int IsEmpPresent()
        {
            return new Random().Next(0, 3);
        }
        public void CalcEmpWage(string CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkHrs = 0;
            int TotalWorkHrs = 0;
            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company doesnt exists");
            Companies.TryGetValue(CompanyName.ToLower(), out EmployeeWage company);

            while (DayNumber < company.MaxWorkDays && TotalWorkHrs <= company.MaxWorkHrs)
            {
                switch (IsEmpPresent())
                {
                    case IsAbsent:
                        EmpWorkHrs = 0;
                        break;
                    case IsPartTime:
                        EmpWorkHrs = company.PartTimeWorkHrsPerDay;
                        break;
                    case IsFullTime:
                        EmpWorkHrs = company.FullTimeWorkHrsPerDay;
                        break;
                }
                EmpDailyWage = EmpWorkHrs * company.EmpWagePerHr;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkHrs += EmpWorkHrs;
            }
            Console.WriteLine("The Name of the Company : " + CompanyName);
            Console.WriteLine("Total Working Days :" + DayNumber + "  " + "Total Working Hours :" + TotalWorkHrs + " " + "Total Employee Wage :" + TotalWage);

        }
    }
}
