using System;
using System.Collections.Generic;

namespace O
{
    public class Program
    {
        // Rule for OCP (Open Close Principle): Should be open to extension, but close to modifications.
        // So: We should do the possible to write a code that shouldn't be changed all the times we need a change of requisite.
        // My Goal Here is: My Senior Employees should gain +20% of salary, and my Mediors should gain +10% of salary. To do it, instead of
        // Changing Calculator, do ifs, create enums - I'll simply create a Specific Calculator and Entity for Seniors and Mediors Employees.        

        static void Main(string[] args)
        {
            //Code Before the Change (code that needs to be changed to support this salary gain):
            /*var employees = new List<IEmployee>();
            employees.Add(new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 });
            employees.Add(new Employee { Name = "Mary Medior", Account = "6677-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 });
            employees.Add(new Employee { Name = "Passaia Senior", Account = "8899-8", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 });

            foreach (IEmployee emp in employees)
            {
                decimal nettoSalary = emp.Calculator.CalculateSalary(emp);
                Console.WriteLine($"{emp.Name}: Gross Salary: {emp.Sallary:C2}, netto salary: {nettoSalary:C2}");
            }
            Console.ReadLine();*/

            var employees = new List<IEmployee>();
            employees.Add(new Employee { Name = "George Junior", Account = "3344-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 });
            employees.Add(new MediorEmployee { Name = "Mary Medior", Account = "6677-5", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 });
            employees.Add(new SeniorEmployee { Name = "Passaia Senior", Account = "8899-8", Sallary = 1000, WorkHoursMonth = 220, WorkedHoursMonth = 200 });

            foreach (IEmployee emp in employees)
            {
                decimal nettoSalary = emp.Calculator.CalculateSalary(emp);
                Console.WriteLine($"{emp.Name}: Gross Salary: {emp.Sallary:C2}, netto salary: {nettoSalary:C2}");
            }
            Console.ReadLine();
        }
    }
}
