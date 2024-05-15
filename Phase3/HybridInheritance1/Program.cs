using System;

namespace HybridInheritance1;
class Program
{
    public static void Main(string[] args)
    {
        Marksheet student1 = new Marksheet("Bhuvanesh","Dhakshinamoorthy",9876543210,new DateTime(2001,07,06),"Male",new double[]{70,77,67,66,76,76}, new double[]{70,77,67,66,76,76},new double[]{70,77,67,66,76,76}, new double[]{70,77,67,66,76,76}, new DateTime(2024,05,02),99);
        student1.Calculate();
        System.Console.WriteLine(student1.ShowMarkSheet());
    }
}