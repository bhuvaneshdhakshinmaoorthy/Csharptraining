using System;
namespace Partial1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Bhuvanesh","Male",new DateTime(2001,07,07),98765543210);
        employee.Update();
        employee.Display();
    }
}