namespace Payslip
{
    public class EmployeeDetails
    {
        private string _employeeName;
        private string _employeeSurname;
        private string _startDate;
        private string _endDate;
  


        public EmployeeDetails(string employeeName, string employeeSurname, string startDate, string endDate)
        {
            _employeeName = employeeName;
            _employeeSurname = employeeSurname;
            _startDate = startDate;
            _endDate = endDate;
        }


        public string GetFirstName()
        {
            return _employeeName;
        }

        public string GetLastName()
        {
            return _employeeSurname;
        }

        public string GetStartDate()
        {
            return _startDate;
        }

        public string GetEndDate()
        {
            return _endDate;
        }

        

    }
    
}