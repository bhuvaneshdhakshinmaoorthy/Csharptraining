using System;
namespace Virtual1;
class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator area = new AreaCalculator(3);
        System.Console.WriteLine(area.Display());
        VolumeCalculator vol = new VolumeCalculator(3,4);
        // System.Console.WriteLine(vol.Calculate());
        System.Console.WriteLine(vol.Display());
    }
}