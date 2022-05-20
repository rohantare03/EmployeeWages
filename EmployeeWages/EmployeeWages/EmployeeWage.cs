using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWage
    {
        public string CompanyName;
        public int WagePerHr;
        public int FullHrPerDay;
        public int PartHrPerDay;
        public int MaxWorkHrs;
        public int MaxWorkDays;

        public EmployeeWage(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays)
        {
            this.CompanyName = CompanyName;
            this.WagePerHr = WagePerHr;
            this.FullHrPerDay = FullHrPerDay;
            this.PartHrPerDay = PartHrPerDay;
            this.MaxWorkHrs = MaxWorkHrs;
            this.MaxWorkDays = MaxWorkDays;
        }

    }
    class WageComputation
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        public Dictionary<string, EmployeeWage> Companies;
        public string[] Company_List;
        public int Company_Index = 0;

        public WageComputation(int Number)
        {
            Companies = new Dictionary<string, EmployeeWage>();
            Company_List = new string[2 * Number];

        }

        public void AddCompany(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays)
        {
            EmployeeWage companies = new EmployeeWage(CompanyName.ToLower(), WagePerHr, FullHrPerDay, PartHrPerDay, MaxWorkHrs, MaxWorkDays);
            Companies.Add(CompanyName.ToLower(), companies);
            Company_List[Company_Index] = CompanyName;
            Company_Index++;
        }
        public int Check_Present()
        {
            return new Random().Next(0, 3);
        }
        public void WageCalculation(string CompanyName)
        {
            int HrPerDay = 0;
            int WagePerDay = 0;
            int PresentDays = 0;
            int TotalWorkHrs = 0;
            int MontlyWage = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company doesn't exists");
            Companies.TryGetValue(CompanyName.ToLower(), out EmployeeWage companies);

            while (TotalWorkHrs < companies.MaxWorkHrs && PresentDays <= companies.MaxWorkDays)
            {
                switch (Check_Present())
                {
                    case FullTime:
                        HrPerDay = companies.FullHrPerDay;
                        PresentDays++;
                        break;
                    case PartTime:
                        HrPerDay = companies.PartHrPerDay;
                        PresentDays++;
                        break;
                    default:
                        HrPerDay = 0;
                        break;
                }
                TotalWorkHrs += HrPerDay;
                WagePerDay = (companies.WagePerHr * HrPerDay);
                MontlyWage += WagePerDay;
            }
            Company_List[Company_Index] = Convert.ToString(MontlyWage);
            Company_Index++;

        }
        public void ViewWage()
        {
            for (int i = 0; i < Company_List.Length; i += 2)
            {
                Console.WriteLine("Montly wage for {0} is {1}", Company_List[i], Company_List[i + 1]);
            }
        }
    }
}
