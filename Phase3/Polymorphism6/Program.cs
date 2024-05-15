using System;
namespace Polymorphism6;
class Program
{
    public static void Main(string[] args)
    {
        Bank bank1 = new SBI();
        Bank bank2 = new ICICI();
        Bank bank3 = new HDFC();
        Bank bank4 = new IDBI();
        System.Console.WriteLine(bank1.GetInterestInfo());
        System.Console.WriteLine(bank2.GetInterestInfo());
        System.Console.WriteLine(bank3.GetInterestInfo());
        System.Console.WriteLine(bank4.GetInterestInfo());
    }
}