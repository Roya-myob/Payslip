namespace Payslip
{
    public class EmployeeDetails
    {
        private  EmployeeName _employeeName;
        private  EmployeeSurname _employeeSurname;
       
        

        public EmployeeDetails(EmployeeName employeeName, EmployeeSurname employeeSurname)
        {
            _employeeName = employeeName;
            _employeeSurname = employeeSurname;
           
        }


        public  EmployeeName GetEmployeeDetailsName()
        {
            return _employeeName;
        }

        public  EmployeeSurname GetEmployeeDetailsSurname()
        {
            return _employeeSurname;
        }

       
        
    }
}