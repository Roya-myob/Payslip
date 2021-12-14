namespace Payslip
{
    public interface IReportGenerator
    {
        string GenerateReport(PayslipReportData payslipReportData);
       
    }

}