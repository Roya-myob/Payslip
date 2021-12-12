namespace Payslip
{
    public class EmployeeSurname
    {
        private string _surname;

        public EmployeeSurname(string surname)
        {
            _surname = surname;
        }

        public string GetSurname()
        {
            return _surname;
        }
    }
}