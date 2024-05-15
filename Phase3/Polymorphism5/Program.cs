using System;
namespace Polymorphism5;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo employee1 = new EmployeeInfo("Bhuvanesh","D",987654321,"Male");
        System.Console.WriteLine(employee1.Display());
        PersonalInfo salary1 = new SalaryInfo("Bhuvanesh","D",987654321,"Male",30);
        System.Console.WriteLine(salary1.Display());
    }
}