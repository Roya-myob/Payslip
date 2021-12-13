using System;
using Payslip;
using Xunit;

namespace PayslipTests
{
    public class TaxCalculatorTest
    {
        [Theory]
        [InlineData(18290, 18201, 37000, 0.19, 0, 1)]
        [InlineData(30000, 18201, 37000, 0.19, 0, 187)]
        [InlineData(60050, 37001, 87000, 0.325, 3572, 922)]
        [InlineData(200000, 180001, Int32.MaxValue, 0.45, 54232, 5269)]
        public void TaxCalculates_Generate_Correct_Tax_For_Given_Salary(int salary, int lowerBound, int higherBound,
            decimal rate, int fixedAmount, decimal expectedResult)
        {
            TaxCalculator taxCalculator = new TaxCalculator();
            Assert.Equal(expectedResult, taxCalculator.Calculate(new EmployeeAnnualSalary(salary)));
        }

        [Theory]
        [InlineData(0, 0, 18200, 0, 0, 0)]
        [InlineData(18200, 0, 18200, 0, 0, 0)]
        [InlineData(18201, 18201, 37000, 0.19, 0, 0)]
        [InlineData(87001, 87001, 180000, 0.37, 19822, 1652)]
        [InlineData(180000, 87001, 180000, 0.37, 19822, 4519)]
        public void TaxCalculator_Generates_Exact_Amount_For_Given_Boundary_Salary(int salary, int lowerBound,
            int higherBound, decimal rate, int fixedAmount, decimal expectedResult)
        {
            TaxCalculator taxCalculator = new TaxCalculator();
            Assert.Equal(expectedResult, taxCalculator.Calculate(new EmployeeAnnualSalary(salary)));
        }
    }
}   