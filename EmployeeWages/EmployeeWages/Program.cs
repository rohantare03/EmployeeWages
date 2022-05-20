// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wages_Computation wages_Computation = new Wages_Computation();
            wages_Computation.AddCompany("TATA", 20, 8, 4, 100, 20);
            wages_Computation.WageCalculation("tata");
            wages_Computation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            wages_Computation.WageCalculation("mahindra");
            wages_Computation.AddCompany("DMART", 40, 8, 5, 100, 20);
            wages_Computation.WageCalculation("dmart");
            wages_Computation.ViewWage();
        }
    }
}
