
namespace O_Wrong
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Sallary { get; set; }
        public string Account { get; set; }
        public int WorkHoursMonth { get; set; }
        public int WorkedHoursMonth { get; set; }
        public EmployeeLevel Level { get; set; } = EmployeeLevel.Junior;
    }
}
