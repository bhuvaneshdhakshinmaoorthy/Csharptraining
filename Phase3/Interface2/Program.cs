using System;
namespace Interface2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Bhuvanesh","Dhaksinamoorthy",987654321);
        System.Console.WriteLine(student.Display());
        EmployeeInfo emp = new EmployeeInfo("Bhuvanesh","Dhaksinamoorthy");
        System.Console.WriteLine(emp.Display());
    }
}