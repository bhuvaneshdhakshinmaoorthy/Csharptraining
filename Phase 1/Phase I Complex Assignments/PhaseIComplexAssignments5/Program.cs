using System;

namespace PhaseIComplexAssignments5
{
    class  Program
    {
        public static void Main(string[] args)
        {
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);

            TimeSpan age = date - dob;
            int totalDays = (int)age.TotalDays;
            int totalHours = (int)age.TotalHours;
            int totalMinutes = (int)age.TotalMinutes;

            Console.WriteLine($"Age : {age.Days/365}");
            Console.WriteLine($"Day : {dob.DayOfWeek}");
            Console.WriteLine($"Number of days : {totalDays}");
            Console.WriteLine($"Number of hours : {totalHours}");
            Console.WriteLine($"Number of minutes : {totalMinutes}");
        }
    }
}