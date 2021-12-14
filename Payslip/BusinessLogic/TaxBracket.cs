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

        public decimal CalculateTax(int annualSalary)
        {
            decimal tax = 0;
            if (annualSalary >= _lowerBound && annualSalary <= _higherBound )
            {
                tax = Math.Round((_fixedAmount + ((annualSalary - _lowerBound) * (decimal)_rate))/12);
            }

            return tax;
        }
    }
}