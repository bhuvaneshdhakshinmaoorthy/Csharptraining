using System;
namespace Abstract1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinders cylinder = new Cylinders(34,32,21);
        System.Console.WriteLine(cylinder.CalculateArea());
        System.Console.WriteLine(cylinder.CalculateVolume());

        Cubes cube = new Cubes(55);
        System.Console.WriteLine(cube.CalculateArea());
        System.Console.WriteLine(cube.CalculateVolume());
    }
}