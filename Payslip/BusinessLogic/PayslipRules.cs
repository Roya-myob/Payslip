using Payslip.BusinessLogic.Interface;

namespace Payslip.BusinessLogic
{
    public class PayslipRules : IPayslipRules
    {
        private ITaxCalculator _taxCalculator;
        private int _annualSalary;
        private int _superRate;

        public PayslipRules(ITaxCalculator taxCalculator, PayslipRulesParameters payslipRulesParameters)
        {
            _taxCalculator = taxCalculator;
            _annualSalary = payslipRulesParameters.GetAnnualSalary();
            _superRate = payslipRulesParameters.GetSuperRate();
        }

        public EmployeeAnnualSalary Run()
        {
            var tax = _taxCalculator.Calculate(_annualSalary);
            
            var grossIncome = GetGrossIncome();
            var super = CalculateSuper();
            var netIncome = GetNetIncome();
            
            var result = new EmployeeAnnualSalary(_annualSalary, grossIncome, tax, netIncome, super);

            return result;
        }
        
        public int GetGrossIncome()
        {
            var grossIncome = (_annualSalary / 12);
            return grossIncome;
        }
        
        public decimal GetNetIncome()
        {
            // Gross - tax
            var tax = _taxCalculator.Calculate(_annualSalary);
            
            return GetGrossIncome() - tax;
        }
        
        public int CalculateSuper()
        {
            var super = (GetGrossIncome() * _superRate) / 100;
            return super;
        }

    }
}