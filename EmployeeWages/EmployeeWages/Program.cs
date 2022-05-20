// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WageComputation computation = new WageComputation(3);
            computation.AddCompany("TATA", 20, 8, 4, 100, 20);
            computation.WageCalculation("tata");
            computation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            computation.WageCalculation("mahindra");
            computation.AddCompany("DMART", 40, 9, 5, 100, 20);
            computation.WageCalculation("dmart");
            computation.ViewWage();
        }
    }
}
