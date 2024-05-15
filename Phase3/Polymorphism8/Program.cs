using System;

namespace Polymorphism8;
class Program
{
    public static void Main(string[] args)
    {
    //    Calculator sem1 = new Calculator(100,99,98,97,96,100);
    //    Calculator sem2 = new Calculator(100,99,98,97,96,100);
    //    Calculator sem3 = new Calculator(100,99,98,97,96,100);
    //    Calculator sem4 = new Calculator(100,99,98,97,96,100);
    //    System.Console.Write($"{sem1.Calculate()} {sem1.Percentage()}");
    //    System.Console.Write($"{sem2.Calculate()} {sem2.Percentage()}");
    //    System.Console.Write($"{sem3.Calculate()} {sem3.Percentage()}");
    //    System.Console.Write($"{sem4.Calculate()} {sem4.Percentage()}");

    Calculator sem1 = new Calculator();
    Calculator sem2 = new Calculator();
    Calculator sem3 = new Calculator();
    Calculator sem4 = new Calculator();
    Calculator total = new Calculator();
    // System.Console.WriteLine(sem1.Calculate(99,98,100,55,55,66));
    // System.Console.WriteLine(sem2.Calculate(99,98,100,55,55,66));
    // System.Console.WriteLine(sem3.Calculate(99,98,100,55,55,66));
    // System.Console.WriteLine(sem4.Calculate(99,98,100,55,55,66));
    System.Console.WriteLine(total.Calculate(sem1.Calculate(99,98,100,55,55,66),sem2.Calculate(99,98,100,55,55,66),sem3.Calculate(99,98,100,55,55,66),sem4.Calculate(99,98,100,55,55,66)));
       
       
       
    }
}