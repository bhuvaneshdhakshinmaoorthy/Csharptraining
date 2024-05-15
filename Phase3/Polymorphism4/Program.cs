using System;
namespace Polymorphism4;
class Program
{
    public static void Main(string[] args)
    {
        FreeLancer free = new FreeLancer("Bharathi","Dhakshinamoorthy","Female","BE","SE",20);
        System.Console.WriteLine(free.CalculateSalary());
        System.Console.WriteLine(free.Display());
        SyncFusion sync = new SyncFusion("Bhuvanesh", "Dhakshinamoorthy","Male","BE","SE",30,"AnnaNagar");
        System.Console.WriteLine(sync.CalculateSalary());
        System.Console.WriteLine(sync.Display());
    }
}