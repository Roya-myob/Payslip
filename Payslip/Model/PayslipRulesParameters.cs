namespace Payslip
{
    public class PayslipRulesParameters
    {
        private int _annualSalary;
        private int _superRate;
        
        public PayslipRulesParameters(int annualSalary, int superRate)
        {
            _annualSalary = annualSalary;
            _superRate = superRate;
        }

        public int GetAnnualSalary()
        {
            return _annualSalary;
        }

        public int GetSuperRate()
        {
            return _superRate;
        }
    }
}