using System;
namespace Partial2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Bhuvanesh","Male",new DateTime(2001,01,01),123456789,100,100,99);
        System.Console.WriteLine(student.Calculate());
        System.Console.WriteLine(student.Percentage());
    }
}