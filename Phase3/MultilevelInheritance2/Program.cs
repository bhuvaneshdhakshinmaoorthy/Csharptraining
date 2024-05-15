using System;
namespace MultilevelInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        BookInfo book1 = new BookInfo("Mech","BE",1,10,"DOM","Ravi",500);
        System.Console.WriteLine(book1.DisplayInfo());
    }
}