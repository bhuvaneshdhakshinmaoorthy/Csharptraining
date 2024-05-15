using System;
namespace HybridInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount account = new SavingsAccount("Bhuvanesh","Male",new DateTime(2001,01,01),987654321,"VID001","AID1001","FSX089",1234567890,AccountType.SavingsAccount);
        System.Console.WriteLine(account.Deposit(500));
        System.Console.WriteLine(account.Withdraw(100));
        System.Console.WriteLine(account.BalanceMethod());
    }
}