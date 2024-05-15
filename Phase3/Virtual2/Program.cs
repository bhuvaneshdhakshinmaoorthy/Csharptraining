using System;
using System.Drawing;
using Virtual2;
namespace Virtual1;
class Program
{
    public static void Main(string[] args)
    {
        RectangleShape rec = new RectangleShape(2,4);
        System.Console.WriteLine(rec.DisplayArea());
        Sphere s = new Sphere(3);
        System.Console.WriteLine(s.DisplayArea());
    }
}