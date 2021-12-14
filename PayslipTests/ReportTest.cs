using System;
using Payslip;
using Xunit;

namespace PayslipTests
{
    public class ReportTest
    {

        [Theory]
        [InlineData("Roya","Taleghani", 1000)]
        public void Generate_Report(string name, string surname, int annualSalary)
        {
            // Arrange
            // IReportGenerator underTest = new PayslipReport();
            // EmployeeDetails details = new EmployeeDetails(name, surname, annualSalary);
            //
            // // Act
            // var result = underTest.GenerateReport(details);
            //
            // // Assert
            // Assert.Equal("Name: Roya Taleghani",result);
        }
    }
}