// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wage_Computation wagecompute = new Wage_Computation(3);
            wagecompute.AddCompany("TATA", 20, 8, 4, 100, 20);
            wagecompute.WageCalculation("tata");
            wagecompute.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            wagecompute.WageCalculation("mahindra");
            wagecompute.AddCompany("DMART", 40, 9, 5, 100, 20);
            wagecompute.WageCalculation("dmart");
            wagecompute.ViewWage();
        }
    }
}
