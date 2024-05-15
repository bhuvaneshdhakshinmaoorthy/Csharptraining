using System;
namespace MultipleInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        ShiftDezire shift = new ShiftDezire("Petrol",5,"Red",25,300,12345,67890,"Swift","Dzire");
        System.Console.WriteLine(shift.ShowDetails());
        Eco eco = new Eco("Diesel",4,"Blue",20,250,09876,54321,"Swift","Eco");
        System.Console.WriteLine(eco.ShowDetails());
    }
}