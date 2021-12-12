using Payslip;
using Xunit;

namespace PayslipTests
{
    public class EmployeeSuperTest
    {
        [Fact]
        public void PaySlip_Calculates_employee_super_for_given_super_rate_and_annual_salary()
        {
            PayslipEngine payslipEngine = new PayslipEngine(new EmployeeSuper(new EmployeeAnnualSalary(60050),9));

            var actual = 450;
            
            Assert.Equal(payslipEngine.EmployeeSuper(), actual);


        }
    }
}