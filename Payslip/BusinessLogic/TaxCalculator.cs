using System;
using System.Collections.Generic;
using Payslip.BusinessLogic.Interface;

namespace Payslip
{
    public class TaxCalculator : ITaxCalculator
    {
        private List<TaxBracket> _taxBracketsList;
        // private EmployeeAnnualSalary _employeeAnnualSalary;
        
        public TaxCalculator()
        {
            _taxBracketsList = new List<TaxBracket>()
            {
                new TaxBracket(0, 18200, 0, 0),
                new TaxBracket(18201, 37000, 0.19, 0),
                new TaxBracket(37001, 87000, 0.325, 3572),
                new TaxBracket(87001, 180000, 0.37, 19822),
                new TaxBracket(180001, Int32.MaxValue, 0.45, 54232)
            };
        }
        
        public decimal Calculate(int annualSalary)
        {
            decimal tax = 0;
            
            _taxBracketsList.ForEach(bracket =>
            {
                tax += bracket.CalculateTax(annualSalary);
            });

            return tax;
        }
    }
}