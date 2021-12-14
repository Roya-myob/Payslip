using System;
using Payslip.BusinessLogic.Interface;
using Payslip.BusinessLogic.ReportGenerator.Interface;

namespace Payslip
{
    public class PayslipReport : IReportGenerator
    {
        public string GenerateReport(PayslipReportData payslipReportData)
        {
            var result = "";

            result = result + $"Name: {payslipReportData.EmployeeDetails.GetFirstName()} {payslipReportData.EmployeeDetails.GetLastName()} {Environment.NewLine}";
            result = result + $"Pay Period: {payslipReportData.EmployeeDetails.GetStartDate()}{payslipReportData.EmployeeDetails.GetEndDate()} {Environment.NewLine}";
            result = result + $"Gross Income: {payslipReportData.EmployeeAnnualSalary.GetGrossIncome()} {Environment.NewLine}";
            result = result + $"Income Tax: {payslipReportData.EmployeeAnnualSalary.GetIncomeTax()} {Environment.NewLine}";
            result = result + $"Net Income: {payslipReportData.EmployeeAnnualSalary.GetNetIncome()} {Environment.NewLine}";
            result = result + $"Super: {payslipReportData.EmployeeAnnualSalary.GetSuper()} {Environment.NewLine}";
            
            return result;
        }

        

     
    }
    
}