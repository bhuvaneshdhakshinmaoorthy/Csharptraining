Using System;
namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(10,20,30);
        Box box2 = new Box(50,60,30);
        System.Console.WriteLine(box1.CalculateVolume());
        System.Console.WriteLine(box2.CalculateVolume());

    
    }
}