namespace O
{
    public interface IEmployee
    {
        string Account { get; set; }
        ICalculator Calculator { get; set; }
        string Name { get; set; }
        decimal Sallary { get; set; }
        int WorkedHoursMonth { get; set; }
        int WorkHoursMonth { get; set; }
    }
}