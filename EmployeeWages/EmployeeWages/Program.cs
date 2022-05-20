// See https://aka.ms/new-console-template for more information
namespace EmployeeWages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wage_Computations wage_Computations = new Wage_Computations();
            wage_Computations.AddCompany("TATA", 20, 8, 4, 100, 20);
            wage_Computations.WageCalculation("tata");
            wage_Computations.AddCompany("TCS", 30, 7, 5, 150, 20);
            wage_Computations.WageCalculation("tcs");
            wage_Computations.AddCompany("TESLA", 50, 9, 5, 200, 20);
            wage_Computations.WageCalculation("tesla");

            Console.WriteLine("Enter the Company name");
            string company = Convert.ToString(Console.ReadLine());
            wage_Computations.Search(company);
        }
    }
}
