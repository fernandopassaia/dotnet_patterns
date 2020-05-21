using System;
using System.Collections.Generic;

namespace O_Wrong
{
    class Program
    {
        // Rule for OCP (Open Close Principle): Should be open to extension, but close to modifications.
        // So: We should do the possible to write a code that shouldn't be changed all the times we need a change of requisite.

        // In this example let's suppose that i need to update this program with the following rule:
        // Seniors employess should have and update of salary of +20%, and mediors an update of +10%. My "choice" here was too
        // create a ENUM, and based on Enum, I'll increase the salary. This Code is OK and Running Perfect, but, if i need to add
        // different levels in the future, I'll need to change my classes here, breaking the OCP rule.        

        // There are other problem: It`s also breaking the S (Single Responsability) in two errors: Once "Calculator" is doing more
        // than calculate. A Class should have one responsability (and in this case Calculator is testing the levels of employee) and
        // one only reason to change (if there are more levels, I'll need to change calculator to calculate this new levels).

        static void Main(string[] args)
        {
            // If you run this program, you'll see that all 3 employees has the same salary, but Medior and Senior netto are different.
            var employees = new List<Employee>();
            employees.Add(new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200, Level = EmployeeLevel.Junior });
            employees.Add(new Employee { Name = "Mary Medior", Account = "6677-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200, Level = EmployeeLevel.Medior });
            employees.Add(new Employee { Name = "Passaia Senior", Account = "8899-8", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200, Level = EmployeeLevel.Senior });

            foreach (Employee emp in employees)
            {
                decimal nettoSalary = Calculator.CalculateSalary(emp);
                Console.WriteLine($"{emp.Name}: Gross Salary: {emp.Sallary:C2}, netto salary: {nettoSalary:C2}");
            }
            Console.ReadLine();
        }
    }
}
