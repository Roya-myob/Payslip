namespace Payslip.BusinessLogic.Interface
{
    public interface ITaxCalculator
    {
        decimal Calculate(int annualSalary);
    }
}