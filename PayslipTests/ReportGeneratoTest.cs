using System;
using Payslip;
using Payslip.BusinessLogic;
using Payslip.BusinessLogic.Interface;
using Payslip.BusinessLogic.ReportGenerator.Interface;
using Xunit;

namespace PayslipTests
{
    public class ReportTest
    {

        [Theory]
        [InlineData("Roya","Taleghani", "1 Jan", "31 Jan", 60050,9,
            "Name: Roya Taleghani \r\nPay Period: 1 Jan - 31 Jan \r\nGross Income: 5004 \r\nIncome Tax: 922 \r\nNet Income: 4082 \r\nSuper: 3004902 \r\n")]
        public void Generate_Report(string name, string surname, string startDate, string endDate, int salary, int super, string expectedResult)
        {
            // Arrange
            ITaxCalculator taxCalculator = new TaxCalculator();
            PayslipRulesParameters payslipRulesParameters = new PayslipRulesParameters(salary, salary);
            PayslipRules payslipRules = new PayslipRules(taxCalculator,payslipRulesParameters);
            var annualSalary = payslipRules.Run();
            
             IReportGenerator reportGenerator = new PayslipReport();
             EmployeeDetails details = new EmployeeDetails(name, surname,startDate, endDate );
            
            
            // Act
             var result = reportGenerator.GenerateReport(new PayslipReportData(details,annualSalary));
            
            // Assert
             Assert.Equal(expectedResult,result);
        }
    }
}