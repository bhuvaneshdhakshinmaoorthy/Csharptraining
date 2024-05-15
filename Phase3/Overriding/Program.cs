using System;
namespace Overriding;
class Program
{
    public static void Main(string[] args)
    {
        Pomerian p = new Pomerian();
        System.Console.WriteLine(p.Sound());
        Animal a = new Pomerian();
        System.Console.WriteLine(a.Sound());
    }
}