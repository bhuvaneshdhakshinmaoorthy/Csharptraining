using System;
using System.Runtime.InteropServices;
namespace MultipleInheritance1;
class Program
{
    public static void Main(string[] args)
    {
        RegisterPerson person1 = new RegisterPerson("Bhuvanesh","Male",new DateTime(2001,07,06),987654321,"Single","Dhakshinamoorthy","Sumathi","Vellore",1);
        System.Console.WriteLine(person1.ShowInfo());      
    }
}