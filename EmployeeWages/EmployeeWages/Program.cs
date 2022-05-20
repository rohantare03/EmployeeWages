// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompanyWage_Computations computations = new CompanyWage_Computations();
            computations.AddCompany("TATA", 20, 8, 4, 100, 20);
            computations.WageCalculation("tata");
            computations.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            computations.WageCalculation("mahindra");
            computations.AddCompany("DMART", 40, 9, 5, 100, 30);
            computations.WageCalculation("dmart");
            computations.ViewWage();
        }
    }
}
