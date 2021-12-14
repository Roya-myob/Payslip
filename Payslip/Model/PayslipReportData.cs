using System;

namespace Payslip
{
    public class PayslipReportData
    {
        public PayslipReportData(EmployeeDetails employeeDetails, EmployeeAnnualSalary employeeAnnualSalary)
        {
            EmployeeDetails = employeeDetails;
            EmployeeAnnualSalary = employeeAnnualSalary;
        }
        
        public EmployeeDetails EmployeeDetails { get;  }
        
        public EmployeeAnnualSalary EmployeeAnnualSalary { get; }
    }
}