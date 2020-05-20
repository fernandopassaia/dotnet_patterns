
namespace O
{
    public class Calculator : ICalculator
    {
        public decimal CalculateSalary(IEmployee employee)
        {
            decimal salary = employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
            return salary;
        }
    }
}
