using System;

namespace S
{
    public static class Payment
    {
        public static void ProcessPayment(Employee employee, decimal nettoSalary)
        {
            Console.WriteLine($"Transfer done: {employee.Name}|{ employee.Account}|{nettoSalary:C2}");
        }
    }
}
