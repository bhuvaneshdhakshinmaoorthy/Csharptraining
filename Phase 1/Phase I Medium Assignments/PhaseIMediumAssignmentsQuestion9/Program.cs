using System;

namespace PhaseIMediumAssignmentsQuestion8
{
    class  Program
    {
        public static void Main(string[] args)
        {
            double monthlySalary = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double leave = double.Parse(Console.ReadLine());

            int totaldays = DateTime.DaysInMonth(year,month);

            double perdaySalary = monthlySalary/totaldays;
            double workingDays = totaldays - leave;
            double final = workingDays*perdaySalary;
            Console.WriteLine($"Take-Home Salary: {Math.Round(final,2)}");
        }
    }
}