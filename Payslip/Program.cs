using System;
using System.Threading;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            // fields to ask employee
            Console.WriteLine("Please enter your name:");
            var firstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your surname:");
            var surName = Console.ReadLine();

            Console.WriteLine("Please enter your annual salary:");
            var annualSalary = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine("Please enter your super rate:");
            var super = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine("Please enter your payment start date:");
            var startDate = Console.ReadLine();
            
            Console.WriteLine("Please enter your payment end date:");
            var endDate = Console.ReadLine();


            // field required for report
            var employeeDetails = new EmployeeDetails(firstName, surName, startDate, endDate);
            var employeeAnnualSalary = new EmployeeAnnualSalary(annualSalary, super);
            
            //
            TaxCalculator calculator = new TaxCalculator();
            var tax = calculator.Calculate(employeeAnnualSalary);
            employeeAnnualSalary.SetTax(tax);
            //
            
            IReportGenerator reportGenerator = new PayslipReport();
           var reportResult = reportGenerator.GenerateReport(new PayslipReportData(employeeDetails,employeeAnnualSalary));
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Your payslip has been generated:" + Environment.NewLine);
            Console.WriteLine(reportResult);
            Console.WriteLine("Thank you for using MYOB!" + Environment.NewLine);
        }
    }
}