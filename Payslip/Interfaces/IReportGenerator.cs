namespace Payslip
{
    public interface IReportGenerator
    {
        string GenerateReport(EmployeeDetails employeeDetails);
    }
}