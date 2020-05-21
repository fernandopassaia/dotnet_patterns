
namespace S
{
    public static class Calculator
    {
        public static decimal CalculateSalary(Employee employee)
        {
            return employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
        }
    }
}
