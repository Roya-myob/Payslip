namespace Payslip.BusinessLogic.ReportGenerator.Interface
{
    public interface IReportGenerator
    {
        string GenerateReport(PayslipReportData payslipReportData);
    }
}