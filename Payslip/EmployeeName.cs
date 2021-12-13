namespace Payslip
{
    public class EmployeeName
    {
        private string _name;


        public EmployeeName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
        
       
    }
}