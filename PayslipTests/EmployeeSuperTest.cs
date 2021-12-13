using Payslip;
using Xunit;

namespace PayslipTests
{
    public class EmployeeSuperTest
    {
        [Fact]
        public void PaySlip_Calculates_Super_For_Given_Super_Rate_And_Annual_Salary()
        {
            PayslipEngine payslipEngine = new PayslipEngine(new EmployeeSuper(new EmployeeAnnualSalary(60050),9));
            var actual = 450;
            Assert.Equal(payslipEngine.EmployeeSuper(), actual);


        }
    }
}