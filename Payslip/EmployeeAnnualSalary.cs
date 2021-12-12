namespace Payslip
{
    public class EmployeeAnnualSalary
    {
        private int _annualSalay;
        

        public EmployeeAnnualSalary(int annualSalay)
        {
            _annualSalay = annualSalay;
        }

        public int GetAnnualSalary()
        {
            return _annualSalay;
        }

        public int GrossIncome()
        {
            var grossIncome = (_annualSalay / 12);
            return grossIncome;
        }

    }
}