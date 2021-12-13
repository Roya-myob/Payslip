using System;
using System.Threading;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            var firstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your surname:");
            var surname = Console.ReadLine();

            Console.WriteLine("Please enter your annual salary:");
            var annualSalary = int.Parse(Console.ReadLine() ?? "0");

            var employeeDetails = new EmployeeDetails(firstName, surname, annualSalary);
            
            IReportGenerator reportGenerator = new PayslipReport();
            var reportResult = reportGenerator.GenerateReport(employeeDetails);
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Report output is:" + Environment.NewLine);
            Console.WriteLine(reportResult);
            Console.WriteLine("End of report" + Environment.NewLine);
        }
    }
}