using Payslip;
using Payslip.BusinessLogic;
using Payslip.BusinessLogic.Interface;
using Xunit;

namespace PayslipTests
{
    public class EmployeeGrossIncomeTest
    {
        [Fact]
        public void PaySlip_Calculates_GrossIncome_For_Given_Annual_Salary()
        {
            // Arrange 
            PayslipRulesParameters payslipRulesParameters = new PayslipRulesParameters(60050, 9);
            ITaxCalculator taxCalculator = new TaxCalculator();
            IPayslipRules payslipRules = new PayslipRules(taxCalculator, payslipRulesParameters);

            var actual = 5004;
            
            // Act
            var expected = payslipRules.GetGrossIncome();
            
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void PaySlip_Calculates_GrossIncome_For_Zero_AnnualSalary()
        {
            // Arrange 
            PayslipRulesParameters payslipRulesParameters = new PayslipRulesParameters(0, 9);
            ITaxCalculator taxCalculator = new TaxCalculator();
            IPayslipRules payslipRules = new PayslipRules(taxCalculator, payslipRulesParameters);

            var actual = 0;
            
            // Act
            var expected = payslipRules.GetGrossIncome();
            
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}