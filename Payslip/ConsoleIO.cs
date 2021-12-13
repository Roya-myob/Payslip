using System;
using System.Globalization;

namespace Payslip
{
    public class ConsoleIO : IO
    {
        //private EmployeeName _name;
        public void AskEmployeeForName()
        {
            Console.WriteLine("Please input your name: ");
           
        }

        public string ReadEmployeeName()
        {
           
            var _name = Console.ReadLine();
            return _name;

        }

        public string GetUserInput()
        {
            var userInput = Console.ReadLine();
            return userInput;
        }

        public void Print(string output)
        {
            
        }

        

        // public void AskEmployeeForSurname()
        // {
        //     Console.WriteLine("Please input your surname: ");
        // }
        //
        // public void AskEmployeeForAnnualSalary()
        // {
        //     Console.WriteLine("Please enter your annual salary: ");
        // }
        //
        // public void AskEmployeeForSuperRate()
        // {
        //     Console.WriteLine("Please enter your super rate: ");
        // }
        //
        // public void AskEmployeeForStartDate()
        // {
        //     Console.WriteLine("Please enter your payment start date: ");
        // }

        // public void AskEmployeeForEndDate()
        // {
        //     Console.WriteLine("Please enter your payment end date: ");
        // }
    }
}