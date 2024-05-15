using System;
namespace Polymorphism1;
class Program
{
    public static void Main(string[] args)
    {
        // Multiply multiply = new Multiply();
        Multiply.Multiply1(1);
        Multiply.Multiply1(1,2);
        Multiply.Multiply1(1,2,3);
        Multiply.Multiply1(5,2.3);
        Multiply.Multiply1(1,2.5,3F);
    }
}