using System;
using Payslip.BusinessLogic;
using Payslip.BusinessLogic.Interface;
using Payslip.BusinessLogic.ReportGenerator.Interface;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capture user input
            Console.WriteLine("Please enter your name:");
            var firstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your surname:");
            var surName = Console.ReadLine();

            Console.WriteLine("Please enter your annual salary:");
            var annualSalary = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine("Please enter your super rate:");
            var superRate = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine("Please enter your payment start date:");
            var startDate = Console.ReadLine();
            
            Console.WriteLine("Please enter your payment end date:");
            var endDate = Console.ReadLine();

            // Annual salary calculation and print report
            var employeeDetails = new EmployeeDetails(firstName, surName, startDate, endDate);
            Start(employeeDetails, annualSalary, superRate);
        }

        private static void Start(EmployeeDetails employeeDetails, int annualSalary, int superRate)
        {
            // Get data needed to generate report
            ITaxCalculator taxCalculator = new TaxCalculator();
            var payslipRulesParameters = new PayslipRulesParameters(annualSalary, superRate);
            var payslipRules = new PayslipRules(taxCalculator, payslipRulesParameters);
            var employeeAnnualSalary = payslipRules.Run();

            // Generate the report by using Annual Salary calculated data
            var payslipReportData = new PayslipReportData(employeeDetails, employeeAnnualSalary);
            IReportGenerator reportGenerator = new PayslipReport();
            var report = reportGenerator.GenerateReport(payslipReportData);
            
            // print report to console
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Your payslip has been generated:" + Environment.NewLine);
            Console.WriteLine(report, ConsoleColor.Green);
            Console.WriteLine("Thank you for using MYOB!" + Environment.NewLine);
        }
    }
}