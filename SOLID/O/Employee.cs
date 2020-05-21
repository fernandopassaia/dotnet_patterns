
namespace O
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public decimal Sallary { get; set; }
        public string Account { get; set; }
        public int WorkHoursMonth { get; set; }
        public int WorkedHoursMonth { get; set; }
        public ICalculator Calculator { get; set; } = new Calculator();
    }
}
