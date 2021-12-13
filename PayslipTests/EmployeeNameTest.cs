using Payslip;
using Xunit;

namespace PayslipTests
{
    public class EmployeeNameTest
    {
        [Fact]
        public void Payslip_takes_employee_name()
        {
            EmployeeName employeeName = new EmployeeName("John");
            var expectedName = employeeName.GetName();
            var actualName = "John";
            Assert.Equal(expectedName,actualName);

        }
        [Fact]
        public void Payslip_takes_employee_surname()
        {
            EmployeeSurname employeeSurname = new EmployeeSurname("Doe");
            var expectedSurname = employeeSurname.GetSurname();
            var actualSurname = "Doe";
            Assert.Equal(expectedSurname,actualSurname);
            
            
        }
        
        
        
    }
}