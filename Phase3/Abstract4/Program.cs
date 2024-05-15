using System;
namespace Abstract4;
class Program
{
    public static void Main(string[] args)
    {
        MensWear men = new MensWear(DressType.MensWear,"Shirt",1000);
        System.Console.WriteLine(men.DisplayInfo());
        LadiesWear ladies = new LadiesWear(DressType.LadiesWear,"Saree",2000);
        System.Console.WriteLine(ladies.DisplayInfo());
    }
}