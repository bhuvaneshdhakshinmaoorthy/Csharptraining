using System;
namespace HierarchicalInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee permanent = new PermanentEmployee(50000,"December","SE");
        System.Console.WriteLine(permanent.ShowSalary());
        TemporaryInfo temp = new TemporaryInfo(50000,"May","SE");
        System.Console.WriteLine(temp.ShowSalary());
    }
}