// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompanyWage_Computation companyWageComputation = new CompanyWage_Computation();
            companyWageComputation.Add_Company("TATA", 20, 8, 4, 100, 20);
            companyWageComputation.Calc_CompanyWage("tata");
            companyWageComputation.Add_Company("MAHINDRA", 30, 8, 4, 100, 20);
            companyWageComputation.Calc_CompanyWage("mahindra");
        }
    }
}
