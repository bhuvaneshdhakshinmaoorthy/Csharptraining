using System;
using Polymorphism7;
namespace Polymorphism6;
class Program
{
    public static void Main(string[] args)
    {
        Attendance attendance1 = new Attendance(30,0,0);
        System.Console.WriteLine(attendance1.Salary());
        // System.Console.WriteLine(attendance1.TotalWorkingDays);;
        
        Attendance attendance2 = new Attendance(30,0,4);
       System.Console.WriteLine(attendance2.Salary());

        Attendance attendance3 = new Attendance(30,5,0);
       System.Console.WriteLine(attendance3.Salary());
    //    System.Console.WriteLine(attendance1.Salary()+attendance2.Salary()+attendance3.Salary());
    }
}