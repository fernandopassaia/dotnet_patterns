using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    public class SeniorCalculator : ICalculator
    {
        public decimal CalculateSalary(IEmployee employee)
        {
            decimal salary = employee.WorkedHoursMonth * (employee.Sallary / employee.WorkHoursMonth);
            salary *= 1.2M;
            return salary;
        }
    }
}
