
namespace O_Wrong
{
    public static class Calculator
    {
        public static decimal CalculateSalary(Employee employee)
        {
            decimal salary = employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
            if(employee.Level == EmployeeLevel.Senior)
            {
                salary *= 1.2M;
            }
            if (employee.Level == EmployeeLevel.Medior)
            {
                salary *= 1.1M;
            }
            return salary;
        }
    }
}
