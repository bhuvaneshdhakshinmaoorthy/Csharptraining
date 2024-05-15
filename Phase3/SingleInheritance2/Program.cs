using System;
namespace SingleInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        AccountInfo acc = new AccountInfo("Bhuvanesh","Dhakshinamoorthy",987654321,"bhuvi@gmail.com",new DateTime(2001,01,01),"Male",1234567890,"kilpauk","BANK1234",500);
        System.Console.WriteLine(acc.ShowAccountInfo());
        System.Console.WriteLine(acc.WithDraw(200));
        System.Console.WriteLine(acc.Deposit(10000));
        
        System.Console.WriteLine(acc.ShowBalance());
    }
}