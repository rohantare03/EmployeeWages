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
    public interface ICompanyEmpWage
    {
        public void AddCompany(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays);
        public void WageCalculation(string CompanyName);
    }
    class Wage_Computation : ICompanyEmpWage
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        public Dictionary<string, EmployeeWage> Companies_Dict;
        public string[] Company_List;
        public int Company_Index = 0;

        public Wage_Computation(int Number)
        {
            Companies_Dict = new Dictionary<string, EmployeeWage>();
            Company_List = new string[2 * Number];

        }

        public void AddCompany(string CompanyName, int WagePerHr, int FullHrPerDay, int PartHrPerDay, int MaxWorkHrs, int MaxWorkDays)
        {
            EmployeeWage company = new EmployeeWage(CompanyName.ToLower(), WagePerHr, FullHrPerDay, PartHrPerDay, MaxWorkHrs, MaxWorkDays);
            Companies_Dict.Add(CompanyName.ToLower(), company);
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

            if (!Companies_Dict.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company doesn't exists");
            Companies_Dict.TryGetValue(CompanyName.ToLower(), out EmployeeWage company);

            while (TotalWorkHrs < company.MaxWorkHrs && PresentDays <= company.MaxWorkDays)
            {
                switch (Check_Present())
                {
                    case FullTime:
                        HrPerDay = company.FullHrPerDay;
                        PresentDays++;
                        break;
                    case PartTime:
                        HrPerDay = company.PartHrPerDay;
                        PresentDays++;
                        break;
                    default:
                        HrPerDay = 0;
                        break;
                }
                TotalWorkHrs += HrPerDay;
                WagePerDay = (company.WagePerHr * HrPerDay);
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
