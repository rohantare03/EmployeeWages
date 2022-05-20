// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageComputation empWageComputation = new EmpWageComputation();
            empWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            empWageComputation.CalcEmpWage("tata");
            empWageComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            empWageComputation.CalcEmpWage("mahindra");
        }
    }
}
