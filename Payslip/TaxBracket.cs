using System;

namespace Payslip
{
    public class TaxBracket
    {
        private int _lowerBound;
        private int _higherBound;
        private double _rate;
        private int _fixedAmount;
        private decimal _tax;

        private EmployeeAnnualSalary _employeeAnnualSalary;

       
        public TaxBracket(int lowerBound, int higherBound, double rate, int fixedAmount)
        {
            _lowerBound = lowerBound;
            _higherBound = higherBound;
            _rate = rate;
            _fixedAmount = fixedAmount;
            
        }

        public decimal CalculateTax(EmployeeAnnualSalary employeeAnnualSalary)
        {
            decimal tax = 0;
            var empAnnualSalary = employeeAnnualSalary.GetAnnualSalary();
            if (empAnnualSalary >= _lowerBound && empAnnualSalary <= _higherBound )
            {
                tax = Math.Round((_fixedAmount + ((empAnnualSalary - _lowerBound) * (decimal)_rate))/12);
            }

            return tax;
        }
    }
}