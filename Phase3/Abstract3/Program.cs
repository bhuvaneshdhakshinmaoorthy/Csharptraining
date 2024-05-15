using System;

namespace Abstract3;
class Program
{
    public static void Main(string[] args)
    {
        Car swift = new MarutiSwift(EngineType.Petrol,4,700000,CarType.Hatchback);
        System.Console.WriteLine(swift.GetCarDetails());
        Car ciaz = new SuzukiCiaz(EngineType.Diesel,5,1000000,CarType.Sedan);
        System.Console.WriteLine(ciaz.GetCarDetails());
    }
}