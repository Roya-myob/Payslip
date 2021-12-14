using System;

namespace Payslip
{
    public class PayslipReport : IReportGenerator
    {
        public string GenerateReport(PayslipReportData payslipReportData)
        {
            var result = "";
            

            result = result + $"Name: {payslipReportData.EmployeeDetails.GetFirstName()} {payslipReportData.EmployeeDetails.GetLastName()} {Environment.NewLine}";
            result = result + $"Pay Period: {payslipReportData.EmployeeDetails.GetStartDate()}{payslipReportData.EmployeeDetails.GetEndDate()}";
            result = result + $"Gross Income: {payslipReportData.EmployeeAnnualSalary.GetGrossIncome()}";
            result = result + $"Income Tax: {payslipReportData.EmployeeAnnualSalary.GetIncomeTax()}";
            result = result + $"Net Income: {payslipReportData.EmployeeAnnualSalary.GetNetIncome()}";
            result = result + $"Super: {payslipReportData.EmployeeAnnualSalary.GetSuper()}";
            
            return result;
        }

        

     
    }
    
}