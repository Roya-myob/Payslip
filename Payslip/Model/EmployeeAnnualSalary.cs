namespace Payslip
{
    public class EmployeeAnnualSalary
    {
        private int _annualSalay;
        private int _grossIncome;
        private decimal _incomeTax;
        private decimal _netIncome;
        private int _super;
        

        public EmployeeAnnualSalary(int annualSalay, int super)
        {
            _annualSalay = annualSalay;
            _super = super;
        }
        
        public EmployeeAnnualSalary(int annualSalay,int grossIncome, decimal incomeTax, decimal netIncome, int super)
        {
            _annualSalay = annualSalay;
            _grossIncome = grossIncome;
            _incomeTax = incomeTax;
            _netIncome = netIncome;
            _super = super;
        }
        public EmployeeAnnualSalary(int annualSalay)
        {
            _annualSalay = annualSalay;
        }

        public void SetTax(decimal tax)
        {
            _incomeTax = tax;
        }

        public int GetAnnualSalary()
        {
            return _annualSalay;
        }

        public int GetGrossIncome()
        {
            return _grossIncome;
        }

        public decimal GetIncomeTax()
        {
            return _incomeTax;
        }

        public decimal GetNetIncome()
        {
            return _netIncome;
        }

        public int GetSuper()
        {
            return _super;
        }
        

    }
}