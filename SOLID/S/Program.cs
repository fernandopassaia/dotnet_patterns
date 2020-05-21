using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    class Program
    {
        //This is a Sample How to Break the S of SOLID: Single Responsability - class should have just one responsability and one reason to change.
        //This class is controlling the flow (first responsability), but also calculating sallary, processing payment and updating bank of hours
        static void Main()
        {
            var employee = new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 };
            decimal nettoSalary = Calculator.CalculateSalary(employee);
            Console.WriteLine($"Junior Salary Gross: {employee.Sallary:C2}, netto sallary: {nettoSalary:C2}");
            Payment.ProcessPayment(employee, nettoSalary);
            BankOfHours.UpdateBankOfHours(employee);
            Console.ReadLine();
        }
    }
}
