namespace Payslip.BusinessLogic.Interface
{
    public interface ITaxCalculator
    {
        decimal CalculateTaxIncome(int annualSalary);
    }
}