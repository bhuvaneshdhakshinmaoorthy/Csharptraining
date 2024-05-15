using System;
namespace SingleInheritance1;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo("Bhuvanesh","D",9876543201,"bhuvanesh@gmail.com",new DateTime(2001,01,02),"Male",4606,11,"Computer Science","2023-2024");
        StudentInfo student2 = new StudentInfo("Ravi","E",9876543201,"ravi@gmail.com",new DateTime(2001,01,01),"Male",46065,12,"EEE Science","2023-2024");        
        System.Console.WriteLine(student1.ShowStudentInfo());
        System.Console.WriteLine(student2.ShowStudentInfo());
    }
}