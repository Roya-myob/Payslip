namespace Payslip
{
    public class EmployeeDetails
    {
        private string _employeeName;
        private string _employeeSurname;
        private int _annualSalary;


        public EmployeeDetails(string employeeName, string employeeSurname, int annualSalary)
        {
            _employeeName = employeeName;
            _employeeSurname = employeeSurname;
            _annualSalary = annualSalary;
        }


        public string GetFirstName()
        {
            return _employeeName;
        }

        public string GetLastName()
        {
            return _employeeSurname;
        }

        public int GetAnnualSalary()
        {
            return _annualSalary;
        }
    }
}