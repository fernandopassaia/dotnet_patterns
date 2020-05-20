using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    public class MediorEmployee : IEmployee
    {
        public string Account { get; set; }
        public ICalculator Calculator { get; set; } = new MediorCalculator();
        public string Name { get; set; }
        public decimal Sallary { get; set; }
        public int WorkedHoursMonth { get; set; }
        public int WorkHoursMonth { get; set; }
    }
}
