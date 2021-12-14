namespace Payslip
{
    public class EmployeeAnnualSalary
    {
        private int _annualSalay;
        private int _grossIncome;
        private decimal _incomeTax;
        private int _netIncome;
        private int _super;
        

        public EmployeeAnnualSalary(int annualSalay, int super)
        {
            _annualSalay = annualSalay;
            _super = super;
        }
        
        public EmployeeAnnualSalary(int annualSalay,int grossIncome, int incomeTax, int netIncome, int super)
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
            var grossIncome = (_annualSalay / 12);
            return _grossIncome;
        }
       

        public decimal GetIncomeTax()
        {
            return _incomeTax;
        }

        public int GetNetIncome()
        {
            return _netIncome;
        }

        public int GetSuper()
        {
            return _super;
        }
        
        public int CalculateSuper()
        {
            var super = (GetGrossIncome() * _super) / 100;
            return super;

          
           
        }

        

    }
}