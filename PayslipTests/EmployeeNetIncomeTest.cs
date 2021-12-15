using Payslip;
using Payslip.BusinessLogic;
using Payslip.BusinessLogic.Interface;
using Xunit;

namespace PayslipTests
{
    public class EmployeeNetIncomeTest
    {
        [Fact]
        public void PaySlip_Calculates_NetIncome_For_Given_Annual_Salary()
        {
            // Arrange 
            PayslipRulesParameters payslipRulesParameters = new PayslipRulesParameters(60050, 9);
            ITaxCalculator taxCalculator = new TaxCalculator();
            IPayslipRules payslipRules = new PayslipRules(taxCalculator, payslipRulesParameters);

            var actual = 4082;
            
            // Act
            var expected = payslipRules.GetNetIncome();
            
            // Assert
            Assert.Equal(expected, actual);
        }
        
    
    }
}