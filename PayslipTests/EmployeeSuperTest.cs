using Payslip;
using Payslip.BusinessLogic;
using Payslip.BusinessLogic.Interface;
using Xunit;

namespace PayslipTests
{
    public class EmployeeSuperTest
    {
        [Fact]
        public void PaySlip_Calculates_Super_For_Given_Super_Rate_And_Annual_Salary()
        {
            // Arrange 
            PayslipRulesParameters payslipRulesParameters = new PayslipRulesParameters(60050, 9);
            ITaxCalculator taxCalculator = new TaxCalculator();
            PayslipRules payslipRules = new PayslipRules(taxCalculator, payslipRulesParameters);
            var actual = 450;

            // Act
            var expected = payslipRules.GetSuperIncome();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}