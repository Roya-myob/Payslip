using System;

namespace Payslip
{
    public class PayslipReport : IReportGenerator
    {
        public string GenerateReport(EmployeeDetails employeeDetails)
        {
            var result = "";

            result = result + $"Name: {employeeDetails.GetFirstName()} {employeeDetails.GetLastName()} {Environment.NewLine}";
            result = result + $"Annual Salary: {employeeDetails.GetAnnualSalary()}";
            
            return result;
        }
    }
    
}