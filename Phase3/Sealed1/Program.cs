using System;

namespace Sealed1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employeeInfo = new EmployeeInfo("welcome");
        System.Console.WriteLine(employeeInfo.DisplayInfo());
        Hack hack = new Hack();
        System.Console.WriteLine(hack.ShowKeyInfo());
    }
}