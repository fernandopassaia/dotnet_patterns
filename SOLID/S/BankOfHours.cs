
using System;

namespace S
{
    public static class BankOfHours
    {
        public static void UpdateBankOfHours(Employee employee)
        {
            Console.WriteLine($"Bank of Hours: {employee.Name} worked {employee.WorkedHoursMonth} on actual month");
        }
    }
}
