using System;

namespace Question12
{
    class  Program
    {
        public static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy",null);

            var day = date.DayOfWeek;
            Console.WriteLine($"The day of the week for {date.ToString("M/dd/yyyy")} is {day}");

        }
    }
}