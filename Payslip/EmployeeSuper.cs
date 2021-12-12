namespace Payslip
{
    public class EmployeeSuper
    {
        private int _super;
        private EmployeeAnnualSalary _employeeAnnualSalary;

        public EmployeeSuper(EmployeeAnnualSalary employeeAnnualSalary, int super)
        {
            _super = super;
            _employeeAnnualSalary = employeeAnnualSalary;
        }
        
        public int CalculateSuper()
        {
            var super = (_employeeAnnualSalary.GrossIncome() * _super) / 100;
            return super;
        }
    }
}