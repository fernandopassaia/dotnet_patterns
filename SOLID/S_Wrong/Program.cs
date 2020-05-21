using System;


namespace S_Wrong
{
    class Program
    {
        //This is a Sample How to Break the S of SOLID: Single Responsability - class should have just one responsability and one reason to change.
        //This class is controlling the flow (first responsability), but also calculating sallary, processing payment and updating bank of hours
        static void Main()
        {
            var employee = new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 };
            decimal nettoSalary = CalculateSalary(employee);
            Console.WriteLine($"Junior Salary Gross: {employee.Sallary:C2}, netto sallary: {nettoSalary:C2}");
            ProcessPayment(employee, nettoSalary);
            UpdateBankOfHours(employee);
            Console.ReadLine();
        }

        private static decimal CalculateSalary(Employee employee)
        {
            return employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
        }

        private static void ProcessPayment(Employee employee, decimal nettoSalary)
        {
            Console.WriteLine($"Transfer done: {employee.Name}|{ employee.Account}|{nettoSalary:C2}");
        }

        private static void UpdateBankOfHours(Employee employee)
        {
            Console.WriteLine($"Bank of Hours: {employee.Name} worked {employee.WorkedHoursMonth} on actual month");
        }
    }
}
