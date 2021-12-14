namespace Payslip.BusinessLogic.Interface
{
    public interface IPayslipRules
    {
        EmployeeAnnualSalary Run();
        int GetGrossIncome();
        decimal GetNetIncome();
        int CalculateSuper();
    }
}