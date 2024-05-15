using System;
using CalculatorApp;
namespace Encapsulation1;
class Program
{
    public static void Main(string[] args)
    {
        CircleArea circle1 = new CircleArea(3);
        System.Console.WriteLine(circle1.CalculateCircleArea());
        CylinderVolume volume1 = new CylinderVolume(3,24);
        System.Console.WriteLine(volume1.CalculateVolume());
    }
}