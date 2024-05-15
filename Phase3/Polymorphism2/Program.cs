using System;
namespace Polymorphism2;
class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square();
        System.Console.WriteLine(square.Squares(5));
        System.Console.WriteLine(square.Squares(5.5F));
        System.Console.WriteLine(square.Squares(5.435234));
        System.Console.WriteLine(square.Squares(5436));
    }
}