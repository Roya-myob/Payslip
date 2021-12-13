using System;
using Payslip;
using Xunit;

namespace PayslipTests
{
    public class ReportTest
    {
        // [Theory]
        // [InlineData("Roya")]
        // public void Generate_Report(string name)
        // {
        //     ReportGenerator reportGenerator = new ReportGenerator(new ConsoleIO());
        //     var report = reportGenerator.CreateReport(new EmployeeName(name));
        //
        //     var testname = report.GetEmployeeName();
        //    
        //     Assert.Equal(testname.GetName(),name);
        // }
        

        
        [Theory]
        [InlineData("Roya","Taleghani", 1000)]
        public void Generate_Report_2(string name, string surname, int annualSalary)
        {
            // Arrange
            IReportGenerator underTest = new PayslipReport();
            EmployeeDetails details = new EmployeeDetails(name, surname, annualSalary);
            
            // Act
            var result = underTest.GenerateReport(details);
            
            // Assert
            Assert.Equal("Name: Roya Taleghani",result);
        }
    }
}